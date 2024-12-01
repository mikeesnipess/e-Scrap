using e_Scrap.Models.Common.GasCooker;
using e_Scrap.Services.MediaGalaxy;
using Microsoft.AspNetCore.Mvc;

namespace e_Scrap.Controllers.MediaGalaxy
{
    [ApiController]
    [Route("[controller]")]
    public class MediaGalaxyGasCookerController : ControllerBase
    {
        private readonly MediaGalaxyGasCookerService _scrapService;
        private readonly AppSettingsDbContext _context;

        public MediaGalaxyGasCookerController(MediaGalaxyGasCookerService scrapService, AppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("ScrapeGasCookerMediaGalaxyProducts")]
        public async Task<ActionResult<List<GasCookerModel>>> ScrapeRefrigeratorProducts()
        {
            try
            {
                List<GasCookerModel> result = await _scrapService.GetMediaGalaxyGasCooker();

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
