using eScrap.Services.eMag;
using Microsoft.EntityFrameworkCore;
using Models.Common.Refrigerator;

public class eMagRefrigeratorService : IEmagRefrigeratorService
{
    private readonly IAppSettingsDbContext _context;

    public eMagRefrigeratorService(IAppSettingsDbContext context)
    {
        _context = context;
    }

    public async Task<List<RefrigeratorModel>> GetRefrigeratorProducts()
    {
        var resultProducts = await _context.eMagRefrigerator
            .Select(r => new RefrigeratorModel
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
