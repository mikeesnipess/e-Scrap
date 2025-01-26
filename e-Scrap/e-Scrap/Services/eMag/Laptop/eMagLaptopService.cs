using eScrap.Models.Common.Laptop;
using Microsoft.EntityFrameworkCore;

namespace eScrap.Services.eMag.Laptop
{
    public class eMagLaptopService : IEmagLaptopService
    {
        private readonly IAppSettingsDbContext _context;

        public eMagLaptopService(IAppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<LaptopModel>> GetEmagLaptop()
        {
            var resultProducts = await _context.eMagLaptop
                 .Select(r => new LaptopModel
                 {
                     Id = r.Id,
                     ProductId = r.ProductId,
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
