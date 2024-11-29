using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Romeilter;
using Romeilter.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<LocalStorageService>();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.VisibleStateDuration = 3000;
    config.SnackbarConfiguration.SnackbarVariant = MudBlazor.Variant.Outlined;
    config.SnackbarConfiguration.HideTransitionDuration = 250;
    config.SnackbarConfiguration.ShowTransitionDuration = 250;
});

await builder.Build().RunAsync();
