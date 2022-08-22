using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Tpl.Core.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<Tpl.Core.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("Test",configureClient => configureClient.BaseAddress = new Uri(@"https://localhost:7257"/*builder.HostEnvironment.BaseAddress*/));

builder.Services.AddSingleton<Tpl.Core.Services.WeatherForecastService>();
builder.Services.AddSingleton<Tpl.Core.Services.WeatherForecastServiceApi>();
builder.Services.AddSingleton<IHardWhare, Tpl.Core.InterfacesIpl.HardWhare>();


await builder.Build().RunAsync();
