using e.Services.Altex;
using Microsoft.AspNetCore.Mvc;
using Models.Common.Refrigerator;

namespace Controllers.Altex
{
    [ApiController]
    [Route("[controller]")]
    public class AltexRefrigeratorController : ControllerBase
    {
        private readonly AltexRefrigeratorService _scrapService;
        private readonly AppSettingsDbContext _context;

        public AltexRefrigeratorController(AltexRefrigeratorService scrapService, AppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("ScrapeRefrigeratorAltexProducts")]
        public async Task<ActionResult<List<RefrigeratorModel>>> ScrapeRefrigeratorProducts()
        {
            try
            {
                List<RefrigeratorModel> result = await _scrapService.GetAltexRefrigerator();

                // Check if the result is null or empty
                if (result == null || result.Count == 0)
                {
                    return NotFound("No products found.");
                }

                // Return the list of products
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log the exception (you may want to use a logging framework)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
