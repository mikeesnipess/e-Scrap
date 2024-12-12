using e_crap.Models.Common.WashMachine;
using Microsoft.AspNetCore.Mvc;
using Services.eMag.WashMachine;

namespace Controllers.eMag.WashMachine
{
    [ApiController]
    [Route("[controller]")]
    public class eMagWashMachineController : ControllerBase
    {
        private readonly IEmagWashMachineService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public eMagWashMachineController(IEmagWashMachineService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("ScrapeEMagWashMachine")]
        public async Task<ActionResult<List<WashMachineModel>>> ScrapGasCookerProducts()
        {
            try
            {
                List<WashMachineModel> result = await _scrapService.GetWashMachineEMag();

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
