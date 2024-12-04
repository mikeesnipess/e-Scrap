using e;
using e_Scrap.Models;
using eScrap.Services;
using Microsoft.EntityFrameworkCore;

public class ShopsService : IShopService
{
    private readonly IAppSettingsDbContext _context;
    public ShopsService(IAppSettingsDbContext context)
    {
        _context = context;
    }

    public async Task<List<ShopsModel>> GetShopsModel()
    {
        var result = await _context.Shops
            .Select(x => new ShopsModel
            {
                Id = x.Id,
                Name = x.Name,
                CountryId = x.CountryId,
            })
            .ToListAsync();

        return result;
    }
}
