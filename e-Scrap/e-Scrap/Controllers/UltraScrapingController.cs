using e.Models;
using Microsoft.AspNetCore.Mvc;

namespace e.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UltraScrapingController : ControllerBase 
    {
        private readonly UltraMdRefrigeratorService _scrapService;

        public UltraScrapingController(UltraMdRefrigeratorService scrapService)
        {
            _scrapService = scrapService;
        }

        [HttpGet("ScrapeRefrigeratorUltraroducts")]
        public async Task<IActionResult> ScrapeProducts(int page = 1)
        {
            try
            {
                // Pass the page parameter to the service method
                List<UltraRefrigeratorModel> products = await _scrapService.ScrapeProductsAsync(page);

                if (products == null || products.Count == 0)
                {
                    return NotFound("No products found.");
                }

                return Ok(products);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}
