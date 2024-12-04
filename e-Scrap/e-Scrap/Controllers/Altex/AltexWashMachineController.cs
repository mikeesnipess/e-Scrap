using e_crap.Models.Common.WashMachine;
using e_Scrap.Services.Altex;
using eScrap.Services.Altex;
using Microsoft.AspNetCore.Mvc;

namespace e_Scrap.Controllers.Altex
{
    [ApiController]
    [Route("[controller]")]
    public class AltexWashMachineController : ControllerBase
    {
        private readonly IAltexWashMachineService _scrapService;
        private readonly IAppSettingsDbContext _context;
        public AltexWashMachineController(IAltexWashMachineService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("ScrapeAltexWashMachine")]
        public async Task<ActionResult<List<WashMachineModel>>> ScrapGasCookerProducts()
        {
            try
            {
                List<WashMachineModel> result = await _scrapService.GetAltexWashMachine();

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
