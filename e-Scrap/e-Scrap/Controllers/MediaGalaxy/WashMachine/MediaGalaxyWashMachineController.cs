using e_crap.Models.Common.WashMachine;
using Microsoft.AspNetCore.Mvc;
using Services.MediaGalaxy.WashMachine;

namespace Controllers.MediaGalaxy.WashMachine
{
    [ApiController]
    [Route("api/media-galaxy")]
    public class MediaGalaxyWashMachineController : ControllerBase
    {
        private readonly IMediaGalaxyWashMachineService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public MediaGalaxyWashMachineController(IMediaGalaxyWashMachineService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("wash-machine")]
        public async Task<ActionResult<List<WashMachineModel>>> ScrapeRefrigeratorProducts()
        {
            List<WashMachineModel> result = await _scrapService.GetMediaGalaxyWashMachine();

            if (result == null || result.Count == 0)
            {
                return NotFound("No products found.");
            }

            return Ok(result);
        }
    }
}
