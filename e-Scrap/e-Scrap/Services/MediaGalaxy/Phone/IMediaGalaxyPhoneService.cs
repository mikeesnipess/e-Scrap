using e_Scrap.Models.Common.Phone;

namespace eScrap.Services.MediaGalaxy.Phone
{
    public interface IMediaGalaxyPhoneService
    {
        Task<List<PhoneModel>> GetProductListAsync();
    }
}
