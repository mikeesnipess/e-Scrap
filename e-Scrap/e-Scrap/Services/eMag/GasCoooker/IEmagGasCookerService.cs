using e_Scrap.Models.Common.GasCooker;

namespace Services.eMag.GasCoooker
{
    public interface IEmagGasCookerService
    {
        Task<List<GasCookerModel>> GetGasCookerProducts();
        Task<List<GasCookerModel>> GetGasCookerEmbeddedProducts();
        Task<List<GasCookerModel>> GetOvenEmbeddedProducts();
        Task<List<GasCookerModel>> GetHoodProducts();
    }
}
