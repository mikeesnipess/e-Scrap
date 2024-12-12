using e_crap.Models.Common.WashMachine;
using Microsoft.EntityFrameworkCore;

namespace Services.Altex.WashMachine
{
    public class AltexWashMachineService : IAltexWashMachineService
    {
        private readonly IAppSettingsDbContext _context;

        public AltexWashMachineService(IAppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<WashMachineModel>> GetAltexWashMachine()
        {
            var resultProducts = await _context.AltexWashMachine
                .Select(r => new WashMachineModel
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
}
