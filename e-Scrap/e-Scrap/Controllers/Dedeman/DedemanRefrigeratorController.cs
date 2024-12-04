using e.Services.Altex;
using eScrap.Services.Dedeman;
using Microsoft.AspNetCore.Mvc;
using Models.Common.Refrigerator;

namespace e_Scrap.Controllers.Dedeman
{
    [ApiController]
    [Route("[controller]")]
    public class DedemanRefrigeratorController : ControllerBase
    {
        private readonly IDedemanRefrigeratorService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public DedemanRefrigeratorController(IDedemanRefrigeratorService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("ScrapeRefrigeratorDedemanProducts")]
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
