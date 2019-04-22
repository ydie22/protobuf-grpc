using System;
using Grpc.Core;
using InvoicingV2;

namespace Server.Tests
{
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