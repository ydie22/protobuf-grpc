using System;
using AutoFixture.Xunit2;
using Grpc.Core;
using InvoicingV2;
using Xunit;

namespace Server.Tests
{
	public class InvoicingServiceFixture : IClassFixture<ServerFixture>, IDisposable
	{
		private readonly Channel _channel;
		private readonly InvoicingService.InvoicingServiceClient _client;

		public InvoicingServiceFixture()
		{
			_channel = new Channel("127.0.0.1:" + ServerFixture.Port, ChannelCredentials.Insecure);

			_client = new InvoicingService.InvoicingServiceClient(_channel);
		}

		[Theory]
		[AutoData]
		public void FindInvoice_WhenCalled_ReturnsAResponse(string invoiceNumber)
		{
			var request = new FindInvoiceRequest {InvoiceNumber = invoiceNumber};
			var response = _client.FindInvoice(request);

			Assert.NotNull(response);
		}

		public void Dispose()
		{
			_channel.ShutdownAsync().Wait();
		}
	}

	public class ServerFixture : IDisposable
	{
		public const int Port = 55555;
		private readonly Grpc.Core.Server _server;

		public ServerFixture()
		{
			_server = new Grpc.Core.Server
			{
				Services = {InvoicingService.BindService(new InvoicingServiceImpl())},
				Ports = {new ServerPort("localhost", Port, ServerCredentials.Insecure)}
			};
			_server.Start();
		}

		public void Dispose()
		{
			_server.ShutdownAsync().Wait();
		}
	}
}