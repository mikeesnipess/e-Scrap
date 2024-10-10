using e.Models;
using Microsoft.AspNetCore.Mvc;

namespace e.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UltraScrapingController : ControllerBase // Use ControllerBase for APIs
    {
        private readonly UltraMdRefrigeratorService _scrapService;

        // Injecting the UltraMdRefrigeratorService into the controller
        public UltraScrapingController(UltraMdRefrigeratorService scrapService)
        {
            _scrapService = scrapService;
        }

        // Remove the Index action if not used in API
        // public IActionResult Index()
        // {
        //     return View();
        // }

        [HttpGet("ScrapeProducts")] // The API endpoint
        public async Task<IActionResult> ScrapeProducts()
        {
            try
            {
                List<UltraRefrigeratorModel> products = await _scrapService.ScrapeProductsAsync();

                if (products == null || products.Count == 0)
                {
                    return NotFound("No products found.");
                }

                return Ok(products); // Return products with a 200 status code
            }
            catch (Exception ex)
            {
                // Log the exception (using your logging framework)
                Console.WriteLine("Error: " + ex.Message); // For debugging purposes
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}
