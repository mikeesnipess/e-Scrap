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

public interface IAppSettingsDbContext
{
    DbSet<AltexRefrigerator> AltexRefrigerator { get; }
    DbSet<AltexGasCooker> AltexGasCooker { get; }
    DbSet<AltexGasCookerEmbedded> AltexGasCookerEmbedded { get; }
    DbSet<AltexOvenEmbedded> AltexOvenEmbedded { get; }
    DbSet<AltexHood> AltexHood { get; }
    DbSet<AltexWashMachine> AltexWashMachine { get; }
    DbSet<AltexPhones> AltexPhones { get; }
    DbSet<AltexLaptop> AltexLaptop{ get; }
    DbSet<eMagGasCooker> eMagGasCooker { get; }
    DbSet<eMagGasCookerEmbedded> eMagGasCookerEmbedded { get; }
    DbSet<eMagOvenEmbedded> eMagOvenEmbedded { get; }
    DbSet<eMagHood> eMagHood { get; }
    DbSet<eMagRefrigerator> eMagRefrigerator { get; }
    DbSet<eMagWashMachine> eMagWashMachine { get; }
    DbSet<eMagPhones> eMagPhones { get; }
    DbSet<eMagLaptop> eMagLaptop { get; }
    DbSet<DedemanRefrigerator> DedemanRefrigerator { get; }
    DbSet<MediaGalaxyRefrigerator> MediaGalaxyRefrigerator { get; }
    DbSet<MediaGalaxyGasCooker> MediaGalaxyGasCooker { get; }
    DbSet<MediaGalaxyGasCookerEmbedded> MediaGalaxyGasCookerEmbedded { get; }
    DbSet<MediaGalaxyOvenEmbedded> MediaGalaxyOvenEmbedded { get; }
    DbSet<MediaGalaxyHood> MediaGalaxyHood { get; }
    DbSet<MediaGalaxyWashMachine> MediaGalaxyWashMachine { get; }
    DbSet<MediaGalaxyPhones> MediaGalaxyPhones { get; }
    DbSet<MediaGalaxyLaptop> MediaGalaxyLaptop{ get; }
    DbSet<Shops> Shops { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
