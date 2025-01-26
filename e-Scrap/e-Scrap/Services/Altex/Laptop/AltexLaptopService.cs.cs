using e_Scrap.Models.Common.Phone;
using eScrap.Models.Common.Laptop;
using Microsoft.EntityFrameworkCore;

namespace eScrap.Services.Altex.Laptop
{
    public class AltexLaptopService : IAltexLaptopService
    {
        private readonly IAppSettingsDbContext _context;

        public AltexLaptopService(IAppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<LaptopModel>> GetLaptopListAsync()
        {
            var resultProducts = await _context.AltexLaptop
               .Select(r => new LaptopModel
                   {
                       Id = r.Id,
                       Name = r.Name,
                       StandardPrice = r.StandardPrice,
                       DiscountPrice = r.DiscountPrice,
                       DiscountPercentage = r.DiscountPercentage,
                       ShopId = r.ShopId,
                       LinkUrl = r.LinkUrl,
                       ProductDescription = r.ProductDescription,
                       CountryId = r.CountryId,
                       ProductType = r.ProductType,
                       ImageSmallUrl = r.ImageSmallUrl,
                       BrandName = r.BrandName,
                   })
               .ToListAsync();

            return resultProducts;
        }
    }
}
