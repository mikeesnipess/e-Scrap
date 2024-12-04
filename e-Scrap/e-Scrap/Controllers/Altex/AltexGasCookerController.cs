using e_Scrap.Models.Common.GasCooker;
using eScrap.Services.Altex;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AltexGasCookerController : ControllerBase
{
    private readonly IAltexGasCookerService _scrapService;
    private readonly IAppSettingsDbContext _context;

    public AltexGasCookerController(IAppSettingsDbContext context, IAltexGasCookerService scrapService)
    {
        _context = context;
        _scrapService = scrapService;
    }

    [HttpGet("ScrapeGasCookerAltexProducts")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapGasCookerProducts()
    {
        try
        {
            List<GasCookerModel> result = await _scrapService.GetGasCookerAltex();

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

