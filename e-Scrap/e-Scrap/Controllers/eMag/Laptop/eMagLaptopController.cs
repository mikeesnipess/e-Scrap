using eScrap.Models.Common.Laptop;
using eScrap.Services.eMag.Laptop;
using Microsoft.AspNetCore.Mvc;

namespace eScrap.Controllers.eMag.Laptop
{
    [ApiController]
    [Route("api/emag/laptop")]
    public class eMagLaptopController : ControllerBase
    {
        private readonly IEmagLaptopService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public eMagLaptopController(IEmagLaptopService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<LaptopModel>>> ScrapLaptopProducts()
        {
            try
            {
                List<LaptopModel> result = await _scrapService.GetEmagLaptop();

                if (result == null || result.Count == 0)
                {
                    return NotFound("No products found.");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
