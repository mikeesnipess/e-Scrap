using eScrap.Models.Common.Laptop;

namespace eScrap.Services.MediaGalaxy.Laptop
{
    public interface IMediaGalaxyLaptopService
    {
        Task<List<LaptopModel>> GetProductListAsync();
    }
}
