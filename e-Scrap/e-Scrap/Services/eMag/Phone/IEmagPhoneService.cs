using e_Scrap.Models.Common.Phone;

namespace eScrap.Services.eMag.Phone
{
    public interface IEmagPhoneService
    {
        Task<List<PhoneModel>> GetEmagPhones();
    }
}
