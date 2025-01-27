using e_Scrap.Components;
using e_Scrap.Components.Pages.Common;
using e_Scrap.Mapping;
using eScrap.Middleware;
using eScrap.Repository;
using eScrap.Services;
using eScrap.Services.Altex.Laptop;
using eScrap.Services.eMag.Laptop;
using eScrap.Services.eMag.Phone;
using eScrap.Services.MediaGalaxy.Laptop;
using eScrap.Services.MediaGalaxy.Phone;
using Microsoft.EntityFrameworkCore;
using Services.Altex.GasCooker;
using Services.Altex.Phone;
using Services.Altex.Refrigerator;
using Services.Altex.WashMachine;
using Services.Dedeman.Refrigerator;
using Services.eMag.GasCoooker;
using Services.eMag.Refrigerator;
using Services.eMag.WashMachine;
using Services.MediaGalaxy.GasCooker;
using Services.MediaGalaxy.Refrigerator;
using Services.MediaGalaxy.WashMachine;


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

RepositoryDeclaration(builder);

builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(MappingProfile));

ServiceDeclaration(builder);
builder.Services.AddTransient(typeof(ProductPage<>));

// Add services to the container
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//.AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();

builder.Services.AddDbContext<IAppSettingsDbContext, AppSettingsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConection"));
});

//builder.Services.AddScoped<IAppSettingsDbContext>(provider => provider.GetRequiredService<AppSettingsDbContext>());

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

app.UseMiddleware<RequestLoggingMiddleware>();

app.UseRouting(); // Ensure routing is enabled

app.UseAntiforgery(); // Place it here, after UseRouting and before UseEndpoints

app.UseCors("AllowAllOrigins"); // Enable CORS policy


// The order of authentication/authorization middleware matters
// Add these only if you're using authentication and authorization
// app.UseAuthentication();
// app.UseAuthorization();

app.MapControllers(); // Ensure controllers are mapped

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    //.AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(e_Scrap.Client._Imports).Assembly);

app.Run();

static void RepositoryDeclaration(WebApplicationBuilder builder)
{
    builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    builder.Services.AddScoped<IAltexLaptopRepository, AltexLaptopRepository>();
    builder.Services.AddScoped<IAltexPhonesRepository, AltexPhonesRepository>();
    builder.Services.AddScoped<IAltexGasCookerRepository, AltexGasCookerRepository>();
    builder.Services.AddScoped<IAltexGasCookerEmbeddedRepository, AltexGasCookerEmbeddedRepository>();
    builder.Services.AddScoped<IAltexOvenEmbeddedRepository, AltexOvenEmbeddedRepository>();
    builder.Services.AddScoped<IAltexHoodRepository, AltexHoodRepository>();
    builder.Services.AddScoped<IAltexWashMachineRepository, AltexWashMachineRepository>();
    builder.Services.AddScoped<IAltexRefrigeratorRepository, AltexRefrigeratorRepository>();

    builder.Services.AddScoped<IMediaGalaxyLaptopRepository, MediaGalaxyLaptopRepository>();
    builder.Services.AddScoped<IMediaGalaxyPhonesRepository, MediaGalaxyPhonesRepository>();
    builder.Services.AddScoped<IMediaGalaxyGasCookerRepository, MediaGalaxyGasCookerRepository>();
    builder.Services.AddScoped<IMediaGalaxyGasCookerEmbeddedRepository, MediaGalaxyGasCookerEmbeddedRepository>();
    builder.Services.AddScoped<IMediaGalaxyOvenEmbeddedRepository, MediaGalaxyOvenEmbeddedRepository>();
    builder.Services.AddScoped<IMediaGalaxyHoodRepository, MediaGalaxyHoodRepository>();
    builder.Services.AddScoped<IMediaGalaxyWashMachineRepository, MediaGalaxyWashMachineRepository>();
    builder.Services.AddScoped<IMediaGalaxyRefrigeratorRepository, MediaGalaxyRefrigeratorRepository>();

    builder.Services.AddScoped<IEMagLaptopRepository, eMagLaptopRepository>();
    builder.Services.AddScoped<IEMagPhonesRepository, eMagPhonesRepository>();
    builder.Services.AddScoped<IEMagGasCookerRepository, eMagGasCookerRepository>();
    builder.Services.AddScoped<IEMagGasCookerEmbeddedRepository, eMagGasCookerEmbeddedRepository>();
    builder.Services.AddScoped<IEMagOvenEmbeddedRepository, eMagOvenEmbeddedRepository>();
    builder.Services.AddScoped<IEMagHoodRepository, eMagHoodRepository>();
    builder.Services.AddScoped<IEMagWashMachineRepository, eMagWashMachineRepository>();
    builder.Services.AddScoped<IEMagRefrigeratorRepository, eMagRefrigeratorRepository>();

    builder.Services.AddScoped<IDedemanRefrigeratorRepository, DedemanRefrigeratorRepository>();
}

static void ServiceDeclaration(WebApplicationBuilder builder)
{
    builder.Services.AddHttpClient<UltraMdRefrigeratorService>();
    builder.Services.AddHttpClient<AltexRefrigeratorService>();
    builder.Services.AddScoped<IAltexRefrigeratorService, AltexRefrigeratorService>();
    builder.Services.AddScoped<IAltexGasCookerService, AltexGasCookerService>();
    builder.Services.AddScoped<IAltexWashMachineService, AltexWashMachineService>();
    builder.Services.AddScoped<IAltexPhoneService, AltexPhoneService>();
    builder.Services.AddScoped<IAltexLaptopService, AltexLaptopService>();
    builder.Services.AddScoped<IEmagGasCookerService, eMagGasCookerService>();
    builder.Services.AddScoped<IEmagRefrigeratorService, eMagRefrigeratorService>();
    builder.Services.AddScoped<IEmagWashMachineService, eMagWashMachineService>();
    builder.Services.AddScoped<IEmagPhoneService, eMagPhoneService>();
    builder.Services.AddScoped<IEmagLaptopService, eMagLaptopService>();
    builder.Services.AddScoped<IDedemanRefrigeratorService, DedemanRefrigeratorService>();
    builder.Services.AddScoped<IMediaGalaxyRefrigeratorService, MediaGalaxyRefrigeratorService>();
    builder.Services.AddScoped<IMediaGalaxyGasCookerService, MediaGalaxyGasCookerService>();
    builder.Services.AddScoped<IMediaGalaxyWashMachineService, MediaGalaxyWashMachineService>();
    builder.Services.AddScoped<IMediaGalaxyPhoneService, MediaGalaxyPhoneService>();
    builder.Services.AddScoped<IMediaGalaxyLaptopService, MediaGalaxyLaptopService>();
    builder.Services.AddScoped<IShopService, ShopsService>();
}