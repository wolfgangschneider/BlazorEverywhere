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
#endif
        builder.Services.AddHttpClient("Test", configureClient => configureClient.BaseAddress = new Uri(@"https://localhost:7257"/*builder.HostEnvironment.BaseAddress*/));

        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<WeatherForecastServiceApi>();

        //unfortunately it seams there is an Error in Maui net6 lo load JS Isolation 
        //https://github.com/dotnet/maui/discussions/6468
        //builder.Services.AddSingleton<IHardWhare, Core.InterfacesIpl.HardWhare>();
        //but luckily we can provide a an IHardWhare Maui Implementation
        builder.Services.AddSingleton<IHardWhare, MauiHardWhare>();

        return builder.Build();
	}
}
