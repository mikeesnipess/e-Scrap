using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var baseAddress = builder.Configuration["BaseAddress"]; // Get BaseAddress from appsettings.json

// Configure HttpClient to communicate with the API
builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri(baseAddress) }); // Use the BaseAddress

await builder.Build().RunAsync();
