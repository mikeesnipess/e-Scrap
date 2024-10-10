using e_Scrap.Components;

var builder = WebApplication.CreateBuilder(args);

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin() // Allow any origin
               .AllowAnyMethod() // Allow any method (GET, POST, etc.)
               .AllowAnyHeader(); // Allow any header
    });
});

builder.Services.AddHttpClient();
builder.Services.AddHttpClient<UltraMdRefrigeratorService>();

// Add services to the container
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();

// Add HttpClient with BaseAddress
builder.Services.AddHttpClient("API", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["BaseAddress"]); // Read BaseAddress from appsettings.json
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting(); // Ensure routing is enabled

app.UseCors("AllowAllOrigins"); // Enable CORS policy

app.UseAntiforgery(); // Place it here, after UseRouting and before UseEndpoints

// The order of authentication/authorization middleware matters
// Add these only if you're using authentication and authorization
// app.UseAuthentication();
// app.UseAuthorization();

app.MapControllers(); // Ensure controllers are mapped

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(e_Scrap.Client._Imports).Assembly);

app.Run();
