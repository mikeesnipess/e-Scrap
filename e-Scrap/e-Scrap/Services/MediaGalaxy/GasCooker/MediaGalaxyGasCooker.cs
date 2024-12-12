using e_Scrap.Models.Common.GasCooker;
using Microsoft.EntityFrameworkCore;

namespace Services.MediaGalaxy.GasCooker
{
    public class MediaGalaxyGasCookerService : IMediaGalaxyGasCookerService
    {
        private readonly IAppSettingsDbContext _context;

        public MediaGalaxyGasCookerService(IAppSettingsDbContext context)
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

        public async Task<List<GasCookerModel>> GetMediaGalaxyGasCookerEmbedded()
        {
            var resultProducts = await _context.MediaGalaxyGasCookerEmbedded
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

        public async Task<List<GasCookerModel>> GetMediaGalaxyHood()
        {
            var resultProducts = await _context.MediaGalaxyHood
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

        public async Task<List<GasCookerModel>> GetMediaGalaxyOvenEmbedded()
        {
            var resultProducts = await _context.MediaGalaxyOvenEmbedded
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
