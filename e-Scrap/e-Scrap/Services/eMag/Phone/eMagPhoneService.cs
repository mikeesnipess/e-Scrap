using e_Scrap.Models.Common.Phone;
using Microsoft.EntityFrameworkCore;

namespace eScrap.Services.eMag.Phone
{
    public class eMagPhoneService : IEmagPhoneService
    {
        private readonly IAppSettingsDbContext _context;

        public eMagPhoneService(IAppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<PhoneModel>> GetEmagPhones()
        {
            var resultProducts = await _context.eMagPhones
                .Select(r => new PhoneModel
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
