using System.Threading.Tasks;
using AutoFixture;
using Grpc.Core;
using Invoicing;
using InvoicingV2;

namespace Server
{
	public class InvoicingServiceImpl : InvoicingService.InvoicingServiceBase
	{
		public override Task<FindInvoiceResponse> FindInvoice(FindInvoiceRequest request, ServerCallContext context)
		{
			var fixture = new Fixture();
			var response = fixture.Create<FindInvoiceResponse>();
			response.Invoice.Lines.AddRange(fixture.CreateMany<InvoiceLine>());
			return Task.FromResult(response);
		}

		public override async Task FindInvoicesByDate(FindInvoicesByDateRequest request, IServerStreamWriter<FindInvoicesByDateResponse> responseStream,
			ServerCallContext context)
		{
			var fixture = new Fixture();
			for (var i = 0; i < 3; i++)
			{
				var response = fixture.Create<FindInvoicesByDateResponse>();
				response.Invoice.Lines.AddRange(fixture.CreateMany<InvoiceLine>());
				await responseStream.WriteAsync(response);
			}
		}
	}
}