using Microsoft.AspNetCore.Mvc;
using Models.Ultra;

namespace Controllers.Ultra
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

        [HttpGet("ScrapeRefrigeratorUltraProducts")]
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
