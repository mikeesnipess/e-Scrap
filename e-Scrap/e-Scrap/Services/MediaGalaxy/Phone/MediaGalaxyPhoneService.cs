using e_Scrap.Models.Common.Phone;
using eScrap.Services.MediaGalaxy.Phone;
using Microsoft.EntityFrameworkCore;

public class MediaGalaxyPhoneService : IMediaGalaxyPhoneService
{

    private readonly IAppSettingsDbContext _context;

    public MediaGalaxyPhoneService(IAppSettingsDbContext context)
    {
        _context = context;
    }

    public async Task<List<PhoneModel>> GetProductListAsync()
    {
        var resultProducts = await _context.MediaGalaxyPhones
        .Select(r => new PhoneModel
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

