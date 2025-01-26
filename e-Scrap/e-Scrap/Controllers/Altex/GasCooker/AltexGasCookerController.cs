using e_Scrap.Models.Common.GasCooker;
using Microsoft.AspNetCore.Mvc;
using Services.Altex.GasCooker;

[ApiController]
[Route("api/altex")]
public class AltexGasCookerController : ControllerBase
{
    private readonly IAltexGasCookerService _scrapService;
    private readonly IAppSettingsDbContext _context;

    public AltexGasCookerController(IAppSettingsDbContext context, IAltexGasCookerService scrapService)
    {
        _context = context;
        _scrapService = scrapService;
    }

    [HttpGet("gas-cooker")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapGasCookerProducts()
    {
        List<GasCookerModel> result = await _scrapService.GetGasCookerAltex();

        if (result == null || result.Count == 0)
        {
            return NotFound("No products found.");
        }

        return Ok(result);
    }

    [HttpGet("gas-cooker-embedded")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapeGasCookerEmbeddedProducts()
    {
        List<GasCookerModel> result = await _scrapService.GetGasCookerEmbeddedAltex();
        if (result == null || result.Count == 0)
        {
            return NotFound("No GasCookerEmbedded products found.");
        }

        return Ok(result);
    }

    [HttpGet("oven-embedded")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapeAltexOvenEmbeddedProducts()
    {
        List<GasCookerModel> result = await _scrapService.GetOvenEmbeddedAltex();
        if (result == null || result.Count == 0)
        {
            return NotFound("No OvenEmbedded products found.");
        }

        return Ok(result);
    }

    [HttpGet("hood")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapeAltexHoodProducts()
    {
        List<GasCookerModel> result = await _scrapService.GetHoodAltex();
        if (result == null || result.Count == 0)
        {
            return NotFound("No AltexHood products found.");
        }

        return Ok(result);
    }
}

