using eScrap.Models.Common.Laptop;
using eScrap.Services.eMag.Laptop;
using Microsoft.AspNetCore.Mvc;

namespace eScrap.Controllers.eMag.Laptop
{
    [ApiController]
    [Route("api/emag")]
    public class eMagLaptopController : ControllerBase
    {
        private readonly IEmagLaptopService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public eMagLaptopController(IEmagLaptopService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("laptop")]
        public async Task<ActionResult<List<LaptopModel>>> ScrapLaptopProducts()
        {
            List<LaptopModel> result = await _scrapService.GetEmagLaptop();

            if (result == null || result.Count == 0)
            {
                return NotFound("No products found.");
            }

            return Ok(result);
        }
    }
}
