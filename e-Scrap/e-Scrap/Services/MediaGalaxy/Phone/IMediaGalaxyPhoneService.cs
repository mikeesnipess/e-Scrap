using e_Scrap.Models.Common.Phone;
using eScrap.Models.Common;

namespace eScrap.Services.MediaGalaxy.Phone
{
    public interface IMediaGalaxyPhoneService
    {
        Task<List<PhoneModel>> GetProductListAsync();
    }
}
