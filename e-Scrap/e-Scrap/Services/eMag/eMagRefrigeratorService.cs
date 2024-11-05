using Microsoft.EntityFrameworkCore;
using Models.eMag;

public class eMagRefrigeratorService
{
    private readonly AppSettingsDbContext _context;

    public eMagRefrigeratorService(AppSettingsDbContext context)
    {
        _context = context;
    }

    public async Task<List<eMagProductModel>> GetRefrigeratorProducts()
    {
        var resultProducts = await _context.eMagRefrigerator
            .Select(r => new eMagProductModel
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
                ProductType = r.ProductType
            })
            .ToListAsync();

        return resultProducts;
    }
}
