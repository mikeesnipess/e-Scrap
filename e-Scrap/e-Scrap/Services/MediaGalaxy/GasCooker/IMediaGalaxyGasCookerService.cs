using e_Scrap.Models.Common.GasCooker;

namespace Services.MediaGalaxy.GasCooker
{
    public interface IMediaGalaxyGasCookerService
    {
        Task<List<GasCookerModel>> GetMediaGalaxyGasCooker();
        Task<List<GasCookerModel>> GetMediaGalaxyGasCookerEmbedded();
        Task<List<GasCookerModel>> GetMediaGalaxyOvenEmbedded();
        Task<List<GasCookerModel>> GetMediaGalaxyHood();
    }
}
