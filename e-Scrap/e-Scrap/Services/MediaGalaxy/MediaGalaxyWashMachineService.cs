using e_crap.Models.Common.WashMachine;
using Microsoft.EntityFrameworkCore;
using Models.Common.Refrigerator;

namespace eScrap.Services.MediaGalaxy
{
    public class MediaGalaxyWashMachineService
    {
        private readonly AppSettingsDbContext _context;

        public MediaGalaxyWashMachineService(AppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<WashMachineModel>> GetMediaGalaxyWashMachine()
        {
            var resultProducts = await _context.MediaGalaxyWashMachine
                .Select(r => new WashMachineModel
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
