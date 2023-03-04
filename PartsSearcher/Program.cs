using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PartsSearcher.Forms;
using PartsSearcher.Services;
using System.Configuration;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PartsSearcher.Data;
using PartsSearcher.Interfaces;
using PartsSearcher.Repositories;
using ConfigurationManager = System.Configuration.ConfigurationManager;


namespace PartsSearcher;


internal static class Program
{
	[STAThread]
	public static async Task Main()
	{
		Application.SetHighDpiMode(HighDpiMode.SystemAware);
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);

		var host = CreateHostBuilder().Build();
		ServiceProvider = host.Services;
		var logger = ServiceProvider.GetRequiredService<ILogger<Object>>();

		var isAvalible = true;
		try
		{	
			var factory = ServiceProvider.GetService<IDbContextFactory<DataContext>>();
			await using var context = await factory.CreateDbContextAsync();
			isAvalible = await context.Database.CanConnectAsync();
		}
		catch (Exception ex)
		{
			logger.LogError(ex, "Error while connecting to database");
		}
		if (!isAvalible)
		{
			MessageBox.Show("Не удалось подключиться к базе данных. Приложение будет закрыто", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			logger.LogWarning("Cannnot connect to database");
			return;
		}

		Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
		var isLoggedIn = ServiceProvider.GetRequiredService<IAuthorization>().IsAuthorized;
		if (!isLoggedIn) return;

		Application.Run(ServiceProvider.GetRequiredService<MainForm>());
	}

	public static IServiceProvider ServiceProvider { get; private set; }

	static IHostBuilder CreateHostBuilder()
	{
		return Host.CreateDefaultBuilder()
			.ConfigureServices((context, services) =>
			{

				services.AddDbContextFactory<DataContext>(options =>
				{
					options.UseSqlServer(ConfigurationManager.ConnectionStrings["PartsDatabase"].ConnectionString);
					options.EnableDetailedErrors();
				});

				services.AddSingleton<IAuthorization, Authorization>();
				services.AddSingleton<IRepositoryFactory, RepositoryFactory>();
				services.AddSingleton<IRepository<Flange>, FlangesRepository>();

				//adding forms
				services.AddTransient<IFormFactory, FormFactory>();
				services.AddTransient<MainForm>();
				services.AddTransient<PartDetailsForm>();
				services.AddTransient<LoginForm>();

			});
	}
}