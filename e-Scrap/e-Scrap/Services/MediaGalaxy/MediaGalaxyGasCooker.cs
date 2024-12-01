using e_Scrap.Models.Common.GasCooker;
using Microsoft.EntityFrameworkCore;
using Models.Common.Refrigerator;

namespace e_Scrap.Services.MediaGalaxy
{
    public class MediaGalaxyGasCookerService
    {
        private readonly AppSettingsDbContext _context;

        public MediaGalaxyGasCookerService(AppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<GasCookerModel>> GetMediaGalaxyGasCooker()
        {
            var resultProducts = await _context.MediaGalaxyGasCooker
                .Select(r => new GasCookerModel
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
