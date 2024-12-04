using e_Scrap.Models.Common.GasCooker;
using eScrap.Services.Altex;
using Microsoft.EntityFrameworkCore;

public class AltexGasCookerService : IAltexGasCookerService
{
    private readonly IAppSettingsDbContext _context;

    public AltexGasCookerService(IAppSettingsDbContext context)
    {
        _context = context;
    }

    public async Task<List<GasCookerModel>> GetGasCookerAltex()
    {
        var resultProducts = await _context.AltexGasCooker
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

