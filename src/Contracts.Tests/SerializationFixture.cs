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
		public void SaveMessage(Invoice expected, InvoiceLine[] lines)
		{
			using (var stream = new FileStream(@"C:\Temp\Invoice.bin", FileMode.Create))
			{
				expected.Lines.AddRange(lines);
				expected.WriteTo(stream);
				stream.Flush();
				_output.WriteLine(expected.ToString());
			}
		}
	}
}