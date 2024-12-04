using e_Scrap.Models.Common.GasCooker;
using e_Scrap.Services.MediaGalaxy;
using eScrap.Services.MediaGalaxy;
using Microsoft.AspNetCore.Mvc;

namespace e_Scrap.Controllers.MediaGalaxy
{
    [ApiController]
    [Route("[controller]")]
    public class MediaGalaxyGasCookerController : ControllerBase
    {
        private readonly IMediaGalaxyGasCookerService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public MediaGalaxyGasCookerController(IMediaGalaxyGasCookerService scrapService, IAppSettingsDbContext context)
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
