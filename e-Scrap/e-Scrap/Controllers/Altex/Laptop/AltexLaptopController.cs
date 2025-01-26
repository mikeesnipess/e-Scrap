using eScrap.Models.Common.Laptop;
using eScrap.Services.Altex.Laptop;
using Microsoft.AspNetCore.Mvc;

namespace eScrap.Controllers.Altex.Laptop
{
    [ApiController]
    [Route("api/altex/laptop")]
    public class AltexLaptopController : ControllerBase
    {
        private readonly IAltexLaptopService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public AltexLaptopController(IAltexLaptopService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<LaptopModel>>> ScrapLaptopProducts()
        {
            try
            {
                List<LaptopModel> result = await _scrapService.GetLaptopListAsync();

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
