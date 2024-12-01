using e.Services.Altex;
using e_Scrap.Services.MediaGalaxy;
using Microsoft.AspNetCore.Mvc;
using Models.Common.Refrigerator;

namespace eScrap.Controllers.MediaGalaxy
{

    [ApiController]
    [Route("[controller]")]
    public class MediaGalaxyRefrigeratorController : ControllerBase
    {
        private readonly MediaGalaxyRefrigeratorService _scrapService;
        private readonly AppSettingsDbContext _context;

        public MediaGalaxyRefrigeratorController(MediaGalaxyRefrigeratorService scrapService, AppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("ScrapeRefrigeratorMediaGalaxyProducts")]
        public async Task<ActionResult<List<RefrigeratorModel>>> ScrapeRefrigeratorProducts()
        {
            try
            {
                List<RefrigeratorModel> result = await _scrapService.GetMediaGalaxyRefrigerator();

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
