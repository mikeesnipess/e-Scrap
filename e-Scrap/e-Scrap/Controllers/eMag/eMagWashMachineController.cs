using e_crap.Models.Common.WashMachine;
using e_crap.Services.eMag;
using Microsoft.AspNetCore.Mvc;

namespace e_Scrap.Controllers.eMag
{
    [ApiController]
    [Route("[controller]")]
    public class eMagWashMachineController : ControllerBase
    {
        private readonly eMagWashMachineService _scrapService;
        private readonly AppSettingsDbContext _context;

        public eMagWashMachineController(eMagWashMachineService scrapService, AppSettingsDbContext context)
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
