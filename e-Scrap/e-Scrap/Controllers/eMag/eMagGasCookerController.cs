using e_Scrap.Models.Common.GasCooker;
using eScrap.Services.eMag;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class eMagGasCookerController : ControllerBase
{
    private readonly IEmagGasCookerService _scrapService;
    private readonly IAppSettingsDbContext _context;

    public eMagGasCookerController(IAppSettingsDbContext context, IEmagGasCookerService scrapService)
    {
        _context = context;
        _scrapService = scrapService;
    }

    [HttpGet("eMagScrapeGasCookerProducts")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapGasCookerProducts()
    {
        try
        {
            List<GasCookerModel> result = await _scrapService.GetGasCookerProducts();

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
