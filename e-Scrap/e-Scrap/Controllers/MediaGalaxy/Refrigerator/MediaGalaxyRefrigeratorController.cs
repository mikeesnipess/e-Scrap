using Microsoft.AspNetCore.Mvc;
using Models.Common.Refrigerator;
using Services.MediaGalaxy.Refrigerator;

namespace Controllers.MediaGalaxy.Refrigerator
{

    [ApiController]
    [Route("api/media-galaxy")]
    public class MediaGalaxyRefrigeratorController : ControllerBase
    {
        private readonly IMediaGalaxyRefrigeratorService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public MediaGalaxyRefrigeratorController(IMediaGalaxyRefrigeratorService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("refrigerator")]
        public async Task<ActionResult<List<RefrigeratorModel>>> ScrapeRefrigeratorProducts()
        {
            List<RefrigeratorModel> result = await _scrapService.GetMediaGalaxyRefrigerator();

            if (result == null || result.Count == 0)
            {
                return NotFound("No products found.");
            }

            return Ok(result);
        }
    }
}
