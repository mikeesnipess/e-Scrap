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

namespace eScrap.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllProductsAsync();
        // Add other common methods if needed
    }

    #region Altex
    public interface IAltexLaptopRepository : IRepository<AltexLaptop>
    {
        // Additional methods specific to AltexLaptop if needed
    }

    public interface IAltexPhonesRepository : IRepository<AltexPhones> { }

    public interface IAltexGasCookerRepository : IRepository<AltexGasCooker> { }
    public interface IAltexGasCookerEmbeddedRepository : IRepository<AltexGasCookerEmbedded> { }

    public interface IAltexOvenEmbeddedRepository : IRepository<AltexOvenEmbedded> { }

    public interface IAltexHoodRepository : IRepository<AltexHood> { }
    public interface IAltexRefrigeratorRepository : IRepository<AltexRefrigerator> { }
    public interface IAltexWashMachineRepository : IRepository<AltexWashMachine> { }
    #endregion

    #region MediaGalaxy
    public interface IMediaGalaxyLaptopRepository : IRepository<MediaGalaxyLaptop> { }

    public interface IMediaGalaxyPhonesRepository : IRepository<MediaGalaxyPhones> { }

    public interface IMediaGalaxyGasCookerRepository : IRepository<MediaGalaxyGasCooker> { }
    public interface IMediaGalaxyGasCookerEmbeddedRepository : IRepository<MediaGalaxyGasCookerEmbedded> { }

    public interface IMediaGalaxyOvenEmbeddedRepository : IRepository<MediaGalaxyOvenEmbedded> { }

    public interface IMediaGalaxyHoodRepository : IRepository<MediaGalaxyHood> { }
    public interface IMediaGalaxyRefrigeratorRepository : IRepository<MediaGalaxyRefrigerator> { }
    public interface IMediaGalaxyWashMachineRepository : IRepository<MediaGalaxyWashMachine> { }
    #endregion

    #region eMag 
    public interface IEMagLaptopRepository : IRepository<eMagLaptop> { }

    public interface IEMagPhonesRepository : IRepository<eMagPhones> { }

    public interface IEMagGasCookerRepository : IRepository<eMagGasCooker> { }
    public interface IEMagGasCookerEmbeddedRepository : IRepository<eMagGasCookerEmbedded> { }

    public interface IEMagOvenEmbeddedRepository : IRepository<eMagOvenEmbedded> { }

    public interface IEMagHoodRepository : IRepository<eMagHood> { }
    public interface IEMagRefrigeratorRepository : IRepository<eMagRefrigerator> { }
    public interface IEMagWashMachineRepository : IRepository<eMagWashMachine> { }
    #endregion

    #region Dedeman
    public interface IDedemanRefrigeratorRepository : IRepository<DedemanRefrigerator> { }
    #endregion
}
