using e_Scrap.Models.Common.Phone;

namespace Services.Altex.Phone
{
    public interface IAltexPhoneService
    {
        Task<List<PhoneModel>> GetPhoneListAsync();
    }
}
