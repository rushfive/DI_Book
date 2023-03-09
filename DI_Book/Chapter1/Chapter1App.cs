using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Book.Chapter1
{
	public class Chapter1App
	{
		private ILogger<Chapter1App> _logger;

		public Chapter1App(
			ILogger<Chapter1App> logger)
		{
			_logger = logger;
		}

		public async Task Run()
		{
			_logger.LogInformation("hello there");
		}

		public static Chapter1App Create()
		{
			var services = new ServiceCollection();

			services
				.AddHttpClient();

			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Information()
				.Enrich.FromLogContext()
				.WriteTo.Console()
				.CreateLogger();

			services.AddLogging(builder =>
			{
				builder.AddSerilog(Log.Logger);
			});

			ServiceProvider serviceProvider = services.BuildServiceProvider();
			return ActivatorUtilities.CreateInstance<Chapter1App>(serviceProvider);
		}
	}
}
