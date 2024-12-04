using e_Scrap.Models.Common.GasCooker;

namespace eScrap.Services.MediaGalaxy
{
    public interface IMediaGalaxyGasCookerService
    {
        Task<List<GasCookerModel>> GetMediaGalaxyGasCooker();
    }
}
