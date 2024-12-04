using e;
using e_Scrap.Models.Common.GasCooker;
using eScrap.Services.eMag;
using Microsoft.EntityFrameworkCore;

public class eMagGasCookerService : IEmagGasCookerService
{
    private readonly IAppSettingsDbContext _context;

    public eMagGasCookerService(IAppSettingsDbContext context)
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
