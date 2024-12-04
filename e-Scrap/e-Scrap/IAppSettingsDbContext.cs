using e.Scrap.Entities.eMag;
using e_Scrap.Entities;
using e_Scrap.Entities.Altex;
using e_Scrap.Entities.Dedeman;
using e_Scrap.Entities.eMag;
using e_Scrap.Entities.MediaGalaxy;
using Entities.Altex;
using eScrap.Entities.MediaGalaxy;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

public interface IAppSettingsDbContext
{
    DbSet<AltexRefrigerator> AltexRefrigerator { get; }
    DbSet<AltexGasCooker> AltexGasCooker { get; }
    DbSet<AltexWashMachine> AltexWashMachine { get; }
    DbSet<eMagGasCooker> eMagGasCooker { get; }
    DbSet<eMagRefrigerator> eMagRefrigerator { get; }
    DbSet<eMagWashMachine> eMagWashMachine { get; }
    DbSet<DedemanRefrigerator> DedemanRefrigerator { get; }
    DbSet<MediaGalaxyRefrigerator> MediaGalaxyRefrigerator { get; }
    DbSet<MediaGalaxyGasCooker> MediaGalaxyGasCooker { get; }
    DbSet<MediaGalaxyWashMachine> MediaGalaxyWashMachine { get; }
    DbSet<Shops> Shops { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
