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

namespace eScrap.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppSettingsDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppSettingsDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllProductsAsync()
        {
            return await _dbSet.ToListAsync();
        }

        // Implement other methods if needed
    }

    #region Altex
    public class AltexLaptopRepository : Repository<AltexLaptop>, IAltexLaptopRepository
    {
        public AltexLaptopRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class AltexPhonesRepository : Repository<AltexPhones>, IAltexPhonesRepository
    {
        public AltexPhonesRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class AltexGasCookerRepository : Repository<AltexGasCooker>, IAltexGasCookerRepository
    {
        public AltexGasCookerRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class AltexGasCookerEmbeddedRepository : Repository<AltexGasCookerEmbedded>, IAltexGasCookerEmbeddedRepository
    {
        public AltexGasCookerEmbeddedRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class AltexOvenEmbeddedRepository : Repository<AltexOvenEmbedded>, IAltexOvenEmbeddedRepository
    {
        public AltexOvenEmbeddedRepository(AppSettingsDbContext context) : base(context) { }
    }
    public class AltexHoodRepository : Repository<AltexHood>, IAltexHoodRepository
    {
        public AltexHoodRepository(AppSettingsDbContext context) : base(context) { }
    }
    public class AltexRefrigeratorRepository : Repository<AltexRefrigerator>, IAltexRefrigeratorRepository
    {
        public AltexRefrigeratorRepository(AppSettingsDbContext context) : base(context) { }
    }
    public class AltexWashMachineRepository : Repository<AltexWashMachine>, IAltexWashMachineRepository
    {
        public AltexWashMachineRepository(AppSettingsDbContext context) : base(context) { }
    }
    #endregion

    #region MediaGalaxy
    public class MediaGalaxyLaptopRepository : Repository<MediaGalaxyLaptop>, IMediaGalaxyLaptopRepository
    {
        public MediaGalaxyLaptopRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class MediaGalaxyPhonesRepository : Repository<MediaGalaxyPhones>, IMediaGalaxyPhonesRepository
    {
        public MediaGalaxyPhonesRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class MediaGalaxyGasCookerRepository : Repository<MediaGalaxyGasCooker>, IMediaGalaxyGasCookerRepository
    {
        public MediaGalaxyGasCookerRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class MediaGalaxyGasCookerEmbeddedRepository : Repository<MediaGalaxyGasCookerEmbedded>, IMediaGalaxyGasCookerEmbeddedRepository
    {
        public MediaGalaxyGasCookerEmbeddedRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class MediaGalaxyOvenEmbeddedRepository : Repository<MediaGalaxyOvenEmbedded>, IMediaGalaxyOvenEmbeddedRepository
    {
        public MediaGalaxyOvenEmbeddedRepository(AppSettingsDbContext context) : base(context) { }
    }
    public class MediaGalaxyHoodRepository : Repository<MediaGalaxyHood>, IMediaGalaxyHoodRepository
    {
        public MediaGalaxyHoodRepository(AppSettingsDbContext context) : base(context) { }
    }
    public class MediaGalaxyRefrigeratorRepository : Repository<MediaGalaxyRefrigerator>, IMediaGalaxyRefrigeratorRepository
    {
        public MediaGalaxyRefrigeratorRepository(AppSettingsDbContext context) : base(context) { }
    }
    public class MediaGalaxyWashMachineRepository : Repository<MediaGalaxyWashMachine>, IMediaGalaxyWashMachineRepository
    {
        public MediaGalaxyWashMachineRepository(AppSettingsDbContext context) : base(context) { }
    }
    #endregion

    #region eMag 
    public class eMagLaptopRepository : Repository<eMagLaptop>, IEMagLaptopRepository
    {
        public eMagLaptopRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class eMagPhonesRepository : Repository<eMagPhones>, IEMagPhonesRepository
    {
        public eMagPhonesRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class eMagGasCookerRepository : Repository<eMagGasCooker>, IEMagGasCookerRepository
    {
        public eMagGasCookerRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class eMagGasCookerEmbeddedRepository : Repository<eMagGasCookerEmbedded>, IEMagGasCookerEmbeddedRepository
    {
        public eMagGasCookerEmbeddedRepository(AppSettingsDbContext context) : base(context) { }
    }

    public class eMagOvenEmbeddedRepository : Repository<eMagOvenEmbedded>, IEMagOvenEmbeddedRepository
    {
        public eMagOvenEmbeddedRepository(AppSettingsDbContext context) : base(context) { }
    }
    public class eMagHoodRepository : Repository<eMagHood>, IEMagHoodRepository
    {
        public eMagHoodRepository(AppSettingsDbContext context) : base(context) { }
    }
    public class eMagRefrigeratorRepository : Repository<eMagRefrigerator>, IEMagRefrigeratorRepository
    {
        public eMagRefrigeratorRepository(AppSettingsDbContext context) : base(context) { }
    }
    public class eMagWashMachineRepository : Repository<eMagWashMachine>, IEMagWashMachineRepository
    {
        public eMagWashMachineRepository(AppSettingsDbContext context) : base(context) { }
    }
    #endregion

    #region Dedeman
    public class DedemanRefrigeratorRepository : Repository<DedemanRefrigerator>, IDedemanRefrigeratorRepository
    {
        public DedemanRefrigeratorRepository(AppSettingsDbContext context) : base(context) { }
    }
    #endregion
}
