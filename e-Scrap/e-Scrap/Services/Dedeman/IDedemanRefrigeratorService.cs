using Models.Common.Refrigerator;

namespace eScrap.Services.Dedeman
{
    public interface IDedemanRefrigeratorService
    {
        Task<List<RefrigeratorModel>> GetAltexRefrigerator();
    }
}
