using e.Services.Altex;
using e_crap.Services.eMag;
using e_Scrap.Components;
using e_Scrap.Mapping;
using e_Scrap.Services.Altex;
using e_Scrap.Services.MediaGalaxy;
using eScrap.Services.MediaGalaxy;
using Microsoft.EntityFrameworkCore;


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
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddHttpClient<UltraMdRefrigeratorService>();
builder.Services.AddHttpClient<AltexRefrigeratorService>();
builder.Services.AddScoped<AltexRefrigeratorService>();
builder.Services.AddScoped<AltexGasCookerService>();
builder.Services.AddScoped<AltexWashMachineService>();
builder.Services.AddScoped<eMagGasCookerService>();
builder.Services.AddScoped<eMagRefrigeratorService>();
builder.Services.AddScoped<eMagWashMachineService>();
builder.Services.AddScoped<DedemanRefrigeratorService>();
builder.Services.AddScoped<MediaGalaxyRefrigeratorService>();
builder.Services.AddScoped<MediaGalaxyGasCookerService>();
builder.Services.AddScoped<MediaGalaxyWashMachineService>();
builder.Services.AddScoped<ShopsService>();

// Add services to the container
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();

builder.Services.AddDbContext<AppSettingsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConection"));
});

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
