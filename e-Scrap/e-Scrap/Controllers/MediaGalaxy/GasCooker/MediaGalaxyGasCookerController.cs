using e_Scrap.Models.Common.GasCooker;
using Microsoft.AspNetCore.Mvc;
using Services.MediaGalaxy.GasCooker;

namespace Controllers.MediaGalaxy.GasCooker
{
    [ApiController]
    [Route("api/media-galaxy")]
    public class MediaGalaxyGasCookerController : ControllerBase
    {
        private readonly IMediaGalaxyGasCookerService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public MediaGalaxyGasCookerController(IMediaGalaxyGasCookerService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("gas-cooker")]
        public async Task<ActionResult<List<GasCookerModel>>> ScrapeGasCookerProducts()
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

        [HttpGet("gas-cooker-embedded")]
        public async Task<ActionResult<List<GasCookerModel>>> GasCookerMediaGalaxyEmbedded()
        {
            try
            {
                List<GasCookerModel> result = await _scrapService.GetMediaGalaxyGasCookerEmbedded();

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

        [HttpGet("oven-embedded")]
        public async Task<ActionResult<List<GasCookerModel>>> OvenMediaGalaxyEmbedded()
        {
            try
            {
                List<GasCookerModel> result = await _scrapService.GetMediaGalaxyOvenEmbedded();

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

        [HttpGet("hood")]
        public async Task<ActionResult<List<GasCookerModel>>> MediaGalaxyHood()
        {
            try
            {
                List<GasCookerModel> result = await _scrapService.GetMediaGalaxyHood();

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
