using AutoMapper;
using e_crap.Models.Common.WashMachine;
using e_Scrap.Models.Common.GasCooker;
using e_Scrap.Models.Common.Phone;
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
using eScrap.Models.Common.Laptop;
using Models.Common.Refrigerator;

namespace e_Scrap.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Altex
            CreateMap<AltexLaptop, LaptopModel>();
            CreateMap<AltexPhones, PhoneModel>();
            CreateMap<AltexGasCooker, GasCookerModel>();
            CreateMap<AltexGasCookerEmbedded, GasCookerModel>();
            CreateMap<AltexOvenEmbedded, GasCookerModel>();
            CreateMap<AltexHood, GasCookerModel>();
            CreateMap<AltexRefrigerator, RefrigeratorModel>();
            CreateMap<AltexWashMachine, WashMachineModel>();
            #endregion

            #region MediaGalaxy
            CreateMap<MediaGalaxyLaptop, LaptopModel>();
            CreateMap<MediaGalaxyPhones, PhoneModel>();
            CreateMap<MediaGalaxyGasCooker, GasCookerModel>();
            CreateMap<MediaGalaxyGasCookerEmbedded, GasCookerModel>();
            CreateMap<MediaGalaxyOvenEmbedded, GasCookerModel>();
            CreateMap<MediaGalaxyHood, GasCookerModel>();
            CreateMap<MediaGalaxyRefrigerator, RefrigeratorModel>();
            CreateMap<MediaGalaxyWashMachine, WashMachineModel>();
            #endregion

            #region eMag
            CreateMap<eMagLaptop, LaptopModel>();
            CreateMap<eMagPhones, PhoneModel>();
            CreateMap<eMagGasCooker, GasCookerModel>();
            CreateMap<eMagGasCookerEmbedded, GasCookerModel>();
            CreateMap<eMagOvenEmbedded, GasCookerModel>();
            CreateMap<eMagHood, GasCookerModel>();
            CreateMap<eMagRefrigerator, RefrigeratorModel>();
            CreateMap<eMagWashMachine, WashMachineModel>();
            #endregion

            #region Dedeman
            CreateMap<DedemanRefrigerator, RefrigeratorModel>();
            #endregion
        }
    }
}
