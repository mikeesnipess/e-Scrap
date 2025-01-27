using e_Scrap.Entities;
using Entities.Altex.GasCooker;
using Entities.Altex.WashMachine;
using Entities.Dedeman.Refrigerator;
using Entities.eMag.GasCooker;
using Entities.eMag.Refrigerator;
using Entities.eMag.WashMachine;
using Entities.MediaGalaxy.GasCooker;
using Entities.MediaGalaxy.Refrigerator;
using Entities.MediaGalaxy.WashMachinie;
using eScrap.Entities.Altex.GasCooker;
using eScrap.Entities.Altex.Laptop;
using eScrap.Entities.Altex.Phone;
using eScrap.Entities.eMag.GasCooker;
using eScrap.Entities.eMag.Laptop;
using eScrap.Entities.eMag.Phone;
using eScrap.Entities.MediaGalaxy.GasCooker;
using eScrap.Entities.MediaGalaxy.Laptop;
using eScrap.Entities.MediaGalaxy.Phone;
using Microsoft.EntityFrameworkCore;

public class AppSettingsDbContext : DbContext, IAppSettingsDbContext
{
    public DbSet<AltexRefrigerator> AltexRefrigerator { get; private set; }
    public DbSet<AltexGasCooker> AltexGasCooker { get; private set; }
    public DbSet<AltexGasCookerEmbedded> AltexGasCookerEmbedded { get; private set; }
    public DbSet<AltexOvenEmbedded> AltexOvenEmbedded{ get; private set; }
    public DbSet<AltexHood> AltexHood{ get; private set; }
    public DbSet<AltexWashMachine> AltexWashMachine { get; private set; }
    public DbSet<AltexPhones> AltexPhones { get; private set; }
    public DbSet<AltexLaptop> AltexLaptop{ get; set; }
    public DbSet<eMagGasCooker> eMagGasCooker { get; private set; }
    public DbSet<eMagGasCookerEmbedded> eMagGasCookerEmbedded { get; private set; }
    public DbSet<eMagOvenEmbedded> eMagOvenEmbedded { get; private set; }
    public DbSet<eMagHood> eMagHood { get; private set; }
    public DbSet<eMagRefrigerator> eMagRefrigerator { get; private set; }
    public DbSet<eMagWashMachine> eMagWashMachine { get; private set; }
    public DbSet<eMagPhones> eMagPhones { get; private set; }
    public DbSet<eMagLaptop> eMagLaptop{ get; private set; }
    public DbSet<DedemanRefrigerator> DedemanRefrigerator { get; private set; }
    public DbSet<MediaGalaxyRefrigerator> MediaGalaxyRefrigerator { get; private set; }
    public DbSet<MediaGalaxyGasCooker> MediaGalaxyGasCooker { get; private set; }
    public DbSet<MediaGalaxyGasCookerEmbedded> MediaGalaxyGasCookerEmbedded { get; private set; }
    public DbSet<MediaGalaxyOvenEmbedded> MediaGalaxyOvenEmbedded { get; private set; }
    public DbSet<MediaGalaxyHood> MediaGalaxyHood { get; private set; }
    public DbSet<MediaGalaxyWashMachine> MediaGalaxyWashMachine { get; private set;}
    public DbSet<MediaGalaxyPhones> MediaGalaxyPhones { get; private set;}
    public DbSet<MediaGalaxyLaptop> MediaGalaxyLaptop{ get; private set;}
    public DbSet<Shops> Shops { get; private set; }


    public AppSettingsDbContext() : base()
    {

    }

    public AppSettingsDbContext(DbContextOptions<AppSettingsDbContext> options) : base(options)
    {

    }
}

