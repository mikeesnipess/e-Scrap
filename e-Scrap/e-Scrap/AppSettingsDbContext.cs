using e;
using e.Scrap.Entities.eMag;
using e_Scrap.Entities;
using e_Scrap.Entities.Altex;
using e_Scrap.Entities.Dedeman;
using e_Scrap.Entities.eMag;
using e_Scrap.Entities.MediaGalaxy;
using Entities.Altex;
using eScrap.Entities.MediaGalaxy;
using Microsoft.EntityFrameworkCore;

public class AppSettingsDbContext : DbContext
{
    public DbSet<AltexRefrigerator> AltexRefrigerator { get; private set; }
    public DbSet<AltexGasCooker> AltexGasCooker { get; private set; }
    public DbSet<AltexWashMachine> AltexWashMachine { get; private set; }
    public DbSet<eMagGasCooker> eMagGasCooker { get; private set; }
    public DbSet<eMagRefrigerator> eMagRefrigerator { get; private set; }
    public DbSet<eMagWashMachine> eMagWashMachine { get; private set; }
    public DbSet<DedemanRefrigerator> DedemanRefrigerator { get; private set; }
    public DbSet<MediaGalaxyRefrigerator> MediaGalaxyRefrigerator { get; private set; }
    public DbSet<MediaGalaxyGasCooker> MediaGalaxyGasCooker { get; private set; }
    public DbSet<MediaGalaxyWashMachine> MediaGalaxyWashMachine { get; private set; }
    public DbSet<Shops> Shops { get; private set; }

    public AppSettingsDbContext() : base()
    {

    }

    public AppSettingsDbContext(DbContextOptions<AppSettingsDbContext> options) : base(options) 
    {
        
    }
}

