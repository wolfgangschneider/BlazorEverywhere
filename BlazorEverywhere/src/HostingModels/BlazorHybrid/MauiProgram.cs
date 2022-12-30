using Microsoft.Extensions.Logging;
using Tpl.Core.Services;
using Tpl.Maui.InterfacesIpl;
using Tpl.Core.Interfaces;

namespace Tpl.Maui;

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
			});

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        builder.Services.AddHttpClient("Test", configureClient => configureClient.BaseAddress = new Uri(@"https://localhost:7257"/*builder.HostEnvironment.BaseAddress*/));

        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<WeatherForecastServiceApi>();

        //builder.Services.AddScoped<IHardWhare, Core.InterfacesIpl.HardWhare>();
        builder.Services.AddSingleton<IHardWhare, MauiHardWhare>();

        return builder.Build();
	}
}
