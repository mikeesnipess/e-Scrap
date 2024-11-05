using Microsoft.AspNetCore.Mvc;
using Models.eMag; // Adjust the namespace according to your project structure
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]
public class eMagGasCookerController : ControllerBase
{
    private readonly eMagGasCookerService _scrapService;
    private readonly AppSettingsDbContext _context;

    public eMagGasCookerController(AppSettingsDbContext context, eMagGasCookerService scrapService)
    {
        _context = context;
        _scrapService = scrapService;
    }

    [HttpGet("eMagScrapeGasCookerProducts")]
    public async Task<ActionResult<List<eMagProductModel>>> ScrapGasCookerProducts()
    {
        try
        {
            List<eMagProductModel> result = await _scrapService.GetGasCookerProducts();

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
