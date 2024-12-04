using e_Scrap.Models;

namespace eScrap.Services
{
    public interface IShopService
    {
        Task<List<ShopsModel>> GetShopsModel();
    }
}
