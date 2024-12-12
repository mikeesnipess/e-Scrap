using Microsoft.EntityFrameworkCore;
using Models.Common.Refrigerator;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Altex.Refrigerator
{
    public class AltexRefrigeratorService : IAltexRefrigeratorService
    {
        private readonly IAppSettingsDbContext _context;
        public AltexRefrigeratorService(IAppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<RefrigeratorModel>> GetAltexRefrigerator()
        {
            var resultProducts = await _context.AltexRefrigerator
                .Select(r => new RefrigeratorModel
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
