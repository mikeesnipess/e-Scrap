using e_Scrap.Models.Common.GasCooker;
using Microsoft.EntityFrameworkCore;

public class eMagGasCookerService
{
    private readonly AppSettingsDbContext _context;

    public eMagGasCookerService(AppSettingsDbContext context)
    {
        _context = context;
    }

    public async Task<List<GasCookerModel>> GetGasCookerProducts()
    {
        var resultProducts = await _context.eMagGasCooker
            .Select(r => new GasCookerModel
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
