using Models.Common.Refrigerator;

namespace eScrap.Services.eMag
{
    public interface IEmagRefrigeratorService
    {
        Task<List<RefrigeratorModel>> GetRefrigeratorProducts();
    }
}
