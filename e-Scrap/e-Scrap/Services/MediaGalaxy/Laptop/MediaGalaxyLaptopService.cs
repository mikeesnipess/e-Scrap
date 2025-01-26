using eScrap.Models.Common.Laptop;
using Microsoft.EntityFrameworkCore;

namespace eScrap.Services.MediaGalaxy.Laptop
{
    public class MediaGalaxyLaptopService : IMediaGalaxyLaptopService
    {
        private readonly IAppSettingsDbContext _context;

        public MediaGalaxyLaptopService(IAppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<LaptopModel>> GetProductListAsync()
        {
            var resultProducts = await _context.MediaGalaxyLaptop
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
