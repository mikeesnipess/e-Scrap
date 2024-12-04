using e_Scrap.Models.Common.GasCooker;

namespace eScrap.Services.eMag
{
    public interface IEmagGasCookerService
    {
        Task<List<GasCookerModel>> GetGasCookerProducts();
    }
}
