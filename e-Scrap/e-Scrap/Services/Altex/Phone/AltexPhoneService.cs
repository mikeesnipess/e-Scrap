using e_Scrap.Models.Common.Phone;
using Microsoft.EntityFrameworkCore;
using Services.Altex.Phone;

public class AltexPhoneService : IAltexPhoneService
{
    private readonly IAppSettingsDbContext _context;

    public AltexPhoneService(IAppSettingsDbContext context)
    {
        _context = context;
    }

    public async Task<List<PhoneModel>> GetPhoneListAsync()
    {
        var resultProducts = await _context.AltexPhones
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

