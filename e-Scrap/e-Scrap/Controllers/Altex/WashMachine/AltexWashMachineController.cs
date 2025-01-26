using e_crap.Models.Common.WashMachine;
using Microsoft.AspNetCore.Mvc;
using Services.Altex.WashMachine;

namespace Controllers.Altex.WashMachine
{
    [ApiController]
    [Route("api/altex")]
    public class AltexWashMachineController : ControllerBase
    {
        private readonly IAltexWashMachineService _scrapService;
        private readonly IAppSettingsDbContext _context;
        public AltexWashMachineController(IAltexWashMachineService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("wash-machine")]
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
