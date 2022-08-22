var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient("Test", configureClient => configureClient.BaseAddress = new Uri(@"https://localhost:7257"/*builder.HostEnvironment.BaseAddress*/));

builder.Services.AddSingleton<Tpl.Core.Services.WeatherForecastService>();
builder.Services.AddSingleton<Tpl.Core.Services.WeatherForecastServiceApi>();

builder.Services.AddScoped<Tpl.Core.Interfaces.IHardWhare, Tpl.Core.InterfacesIpl.HardWhare>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
