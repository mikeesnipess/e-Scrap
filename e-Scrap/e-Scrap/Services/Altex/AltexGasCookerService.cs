

using Microsoft.EntityFrameworkCore;
using Models.Altex;

public class AltexGasCookerService
{
    private readonly AppSettingsDbContext _context;

    public AltexGasCookerService(AppSettingsDbContext context)
    {
        _context = context;
    }

    public async Task<List<AltexProductsModel>> GetGasCookerAltex()
    {
        var resultProducts = await _context.AltexGasCooker
            .Select(r => new AltexProductsModel
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

