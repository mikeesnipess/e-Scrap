using e_crap.Models.Common.WashMachine;
using e_Scrap.Services.MediaGalaxy;
using eScrap.Services.MediaGalaxy;
using Microsoft.AspNetCore.Mvc;
using Models.Common.Refrigerator;

namespace eScrap.Controllers.MediaGalaxy
{
    [ApiController]
    [Route("[controller]")]
    public class MediaGalaxyWashMachineController : ControllerBase
    {
        private readonly MediaGalaxyWashMachineService _scrapService;
        private readonly AppSettingsDbContext _context;

        public MediaGalaxyWashMachineController(MediaGalaxyWashMachineService scrapService, AppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("ScrapeWashMachineMediaGalaxyProducts")]
        public async Task<ActionResult<List<WashMachineModel>>> ScrapeRefrigeratorProducts()
        {
            try
            {
                List<WashMachineModel> result = await _scrapService.GetMediaGalaxyWashMachine();

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
