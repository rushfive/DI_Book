using DI_Book.Chapter1;

namespace DI_Book
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			var app = Chapter1App.Create();
			await app.Run();





			Console.WriteLine("End Program.");
			Console.ReadKey();
		}
	}
}