using e_Scrap.Models.Common.GasCooker;
using Microsoft.EntityFrameworkCore;
using Services.eMag.GasCoooker;

public class eMagGasCookerService : IEmagGasCookerService
{
    private readonly IAppSettingsDbContext _context;

    public eMagGasCookerService(IAppSettingsDbContext context)
    {
        _context = context;
    }

    public async Task<List<GasCookerModel>> GetGasCookerEmbeddedProducts()
    {
        var resultProducts = await _context.eMagGasCookerEmbedded
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

    public async Task<List<GasCookerModel>> GetHoodProducts()
    {
        var resultProducts = await _context.eMagHood
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

    public async Task<List<GasCookerModel>> GetOvenEmbeddedProducts()
    {
        var resultProducts = await _context.eMagOvenEmbedded
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
