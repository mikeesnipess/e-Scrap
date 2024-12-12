using e_crap.Models.Common.WashMachine;
using Microsoft.EntityFrameworkCore;

namespace Services.eMag.WashMachine
{
    public class eMagWashMachineService : IEmagWashMachineService
    {
        private readonly IAppSettingsDbContext _context;
        public eMagWashMachineService(IAppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<WashMachineModel>> GetWashMachineEMag()
        {
            var resultProducts = await _context.eMagWashMachine
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