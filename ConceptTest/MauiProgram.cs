using ConceptTest.ViewModels;
using Microsoft.Extensions.Logging;

namespace ConceptTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<MainViewModel>();
		builder.Services.AddTransient<ListViewModel>();
		builder.Services.AddSingleton<NavigationPage>();



		var app = builder.Build();
		Startup.ServiceProvider = app.Services;
		return app;
	}
}
