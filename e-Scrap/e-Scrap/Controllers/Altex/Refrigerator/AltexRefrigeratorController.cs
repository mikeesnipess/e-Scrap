using Microsoft.AspNetCore.Mvc;
using Models.Common.Refrigerator;
using Services.Altex.Refrigerator;

namespace Controllers.Altex.Refrigerator
{
    [ApiController]
    [Route("api/altex")]
    public class AltexRefrigeratorController : ControllerBase
    {
        private readonly IAltexRefrigeratorService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public AltexRefrigeratorController(IAltexRefrigeratorService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("refrigerator")]
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
