using Models.Common.Refrigerator;

namespace Services.eMag.Refrigerator
{
    public interface IEmagRefrigeratorService
    {
        Task<List<RefrigeratorModel>> GetRefrigeratorProducts();
    }
}
