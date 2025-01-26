using eScrap.Models.Common.Laptop;
using eScrap.Services.MediaGalaxy.Laptop;
using Microsoft.AspNetCore.Mvc;

namespace eScrap.Controllers.MediaGalaxy.Laptop
{
    [ApiController]
    [Route("api/media-galaxy/laptop")]
    public class MediaGalaxyLaptopController : ControllerBase
    {
        private readonly IMediaGalaxyLaptopService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public MediaGalaxyLaptopController(IMediaGalaxyLaptopService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<LaptopModel>>> ScrapLaptopProducts()
        {
            try
            {
                List<LaptopModel> result = await _scrapService.GetProductListAsync();

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
