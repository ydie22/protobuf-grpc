using System;
using System.Threading;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using InvoicingV2;
using Xunit;
using Xunit.Abstractions;

namespace Server.Tests
{
	public class InvoicingServiceFixture : IClassFixture<ServerFixture>, IDisposable
	{
		private readonly Channel _channel;
		private readonly InvoicingService.InvoicingServiceClient _client;
		private readonly ITestOutputHelper _output;

		public InvoicingServiceFixture(ITestOutputHelper output)
		{
			_output = output;
			_channel = new Channel("127.0.0.1:" + ServerFixture.Port, ChannelCredentials.Insecure);

			_client = new InvoicingService.InvoicingServiceClient(_channel);
		}


		public void Dispose()
		{
			_channel.ShutdownAsync().Wait();
		}

		[Theory]
		[AutoData]
		public async Task FindInvoice_WhenCalled_ReturnsAResponse(string invoiceNumber)
		{
			var request = new FindInvoiceRequest {InvoiceNumber = invoiceNumber};
			var response = await _client.FindInvoiceAsync(request);

			Assert.NotNull(response);
			_output.WriteLine("Got invoice with number {0}", response.Invoice.InvoiceNumber);
		}

		[Theory]
		[AutoData]
		public async Task FindInvoicesByDate_WhenCalled_ReturnsAResponse(Timestamp startDate, Timestamp endDate)
		{
			var request = new FindInvoicesByDateRequest
				{StartDate = startDate, EndDate = endDate};
			using (var call = _client.FindInvoicesByDate(request))
			{
				var responseStream = call.ResponseStream;
				while (await responseStream.MoveNext(CancellationToken.None))
				{
					var invoice = responseStream.Current.Invoice;
					_output.WriteLine("Got invoice with number {0}", invoice.InvoiceNumber);
				}
			}
		}
	}
}