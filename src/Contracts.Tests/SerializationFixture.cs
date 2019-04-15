using System.IO;
using AutoFixture.Xunit2;
using Google.Protobuf;
using Invoicing;
using Xunit;
using Xunit.Abstractions;

namespace Contracts.Tests
{
	public class SerializationFixture
	{
		private readonly ITestOutputHelper _output;

		public SerializationFixture(ITestOutputHelper output)
		{
			_output = output;
		}

		[Theory]
		[AutoData]
		public void CanRoundtripMessage(Invoice expected)
		{
			using (var stream = new MemoryStream())
			{
				expected.WriteTo(stream);
				stream.Flush();
				stream.Position = 0;
				var actual = Invoice.Parser.ParseFrom(stream);
				Assert.Equal(expected, actual);
			}
		}

		[Theory]
		[AutoData]
		public void SaveV1Message(Invoice expected, InvoiceLine[] lines)
		{
			using (var stream = new FileStream(@"C:\Temp\InvoiceV1.bin", FileMode.Create))
			{
				expected.Lines.AddRange(lines);
				expected.WriteTo(stream);
				stream.Flush();
				_output.WriteLine(expected.ToString());
			}
		}

		[Theory]
		[AutoData]
		public void SaveV2Message(InvoicingV2.Invoice expected, InvoiceLine[] lines)
		{
			using (var stream = new FileStream(@"C:\Temp\InvoiceV2.bin", FileMode.Create))
			{
				expected.Lines.AddRange(lines);
				expected.WriteTo(stream);
				stream.Flush();
				_output.WriteLine(expected.ToString());
			}
		}

		[Theory]
		[AutoData]
		public void V1ClientCanReadV2Message(InvoicingV2.Invoice expected)
		{
			using (var stream = new MemoryStream())
			{
				expected.WriteTo(stream);
				stream.Flush();
				stream.Position = 0;
				var actual = Invoice.Parser.ParseFrom(stream);
				Assert.Equal(expected.CustomerName, actual.CustomerName);
				Assert.Equal(expected.TotalAmount, actual.TotalAmount);
				Assert.Equal(default(int), actual.CustomerId);
			}
		}

		[Theory]
		[AutoData]
		public void V2ClientCanReadV1Message(Invoice expected)
		{
			using (var stream = new MemoryStream())
			{
				expected.WriteTo(stream);
				stream.Flush();
				stream.Position = 0;
				var actual = InvoicingV2.Invoice.Parser.ParseFrom(stream);
				Assert.Equal(expected.CustomerName, actual.CustomerName);
				Assert.Equal(expected.TotalAmount, actual.TotalAmount);
				Assert.Equal(string.Empty, actual.CustomerAddress);
			}
		}
	}
}