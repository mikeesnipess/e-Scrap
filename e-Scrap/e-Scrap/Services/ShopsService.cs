using e_Scrap.Models;
using Microsoft.EntityFrameworkCore;

public class ShopsService
{
    private readonly AppSettingsDbContext _context;
    public ShopsService(AppSettingsDbContext context)
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
