using e_Scrap.Models.Common.GasCooker;

namespace Services.Altex.GasCooker
{
    public interface IAltexGasCookerService
    {
        Task<List<GasCookerModel>> GetGasCookerAltex();
        Task<List<GasCookerModel>> GetGasCookerEmbeddedAltex();
        Task<List<GasCookerModel>> GetOvenEmbeddedAltex();
        Task<List<GasCookerModel>> GetHoodAltex();
    }
}
