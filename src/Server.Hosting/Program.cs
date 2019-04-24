using System;
using Server.Tests;

namespace Server.Hosting
{
	class Program
	{
		static void Main(string[] args)
		{
			using (new ServerFixture())
			{
				Console.WriteLine("Press any key to STOP the server.");
				Console.ReadKey();
			}
		}
	}
}
