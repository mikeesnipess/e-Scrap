using Models.Common.Refrigerator;

namespace Services.MediaGalaxy.Refrigerator
{
    public interface IMediaGalaxyRefrigeratorService
    {
        Task<List<RefrigeratorModel>> GetMediaGalaxyRefrigerator();
    }
}
