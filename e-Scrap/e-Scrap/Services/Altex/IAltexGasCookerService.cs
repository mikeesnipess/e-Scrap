using e_Scrap.Models.Common.GasCooker;

namespace eScrap.Services.Altex
{
    public interface IAltexGasCookerService
    {
        Task<List<GasCookerModel>> GetGasCookerAltex();
    }
}
