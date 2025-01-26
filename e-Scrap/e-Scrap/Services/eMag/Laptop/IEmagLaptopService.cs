using e_Scrap.Models.Common.Phone;
using eScrap.Models.Common.Laptop;

namespace eScrap.Services.eMag.Laptop
{
    public interface IEmagLaptopService
    {
        Task<List<LaptopModel>> GetEmagLaptop();
    }
}
