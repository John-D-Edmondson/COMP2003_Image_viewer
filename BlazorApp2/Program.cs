using BlazorApp2;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://web.socem.plymouth.ac.uk/COMP2003/COMP2003_Y/api/") });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7088/api/") });
builder.Services.AddScoped<IImageHttpRepo,ImageHttpRepo>();

await builder.Build().RunAsync();
