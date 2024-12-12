using Models.Common.Refrigerator;

namespace Services.Dedeman.Refrigerator
{
    public interface IDedemanRefrigeratorService
    {
        Task<List<RefrigeratorModel>> GetAltexRefrigerator();
    }
}
