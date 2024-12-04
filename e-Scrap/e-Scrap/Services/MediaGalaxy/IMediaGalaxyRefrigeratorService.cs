using Models.Common.Refrigerator;

namespace eScrap.Services.MediaGalaxy
{
    public interface IMediaGalaxyRefrigeratorService
    {
        Task<List<RefrigeratorModel>> GetMediaGalaxyRefrigerator();
    }
}
