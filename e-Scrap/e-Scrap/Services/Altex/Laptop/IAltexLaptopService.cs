using eScrap.Models.Common.Laptop;

namespace eScrap.Services.Altex.Laptop
{
    public interface IAltexLaptopService
    {
        Task<List<LaptopModel>> GetLaptopListAsync();
    }
}
