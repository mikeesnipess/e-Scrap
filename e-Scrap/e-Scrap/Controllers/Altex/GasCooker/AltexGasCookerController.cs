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

    [HttpGet("gas-cooker-embedded")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapeGasCookerEmbeddedProducts()
    {
        try
        {
            List<GasCookerModel> result = await _scrapService.GetGasCookerEmbeddedAltex();
            if (result == null || result.Count == 0)
            {
                return NotFound("No GasCookerEmbedded products found.");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {

            return StatusCode(500, $"Internet server error {ex.Message}");
        }
    }

    [HttpGet("oven-embedded")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapeAltexOvenEmbeddedProducts()
    {
        try
        {
            List<GasCookerModel> result = await _scrapService.GetOvenEmbeddedAltex();
            if (result == null || result.Count == 0)
            {
                return NotFound("No OvenEmbedded products found.");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internest server error {ex.Message}");
        }
    }

    [HttpGet("hood")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapeAltexHoodProducts()
    {
        try
        {
            List<GasCookerModel> result = await _scrapService.GetHoodAltex();
            if (result == null || result.Count == 0)
            {
                return NotFound("No AltexHood products found."); 
            }

            return Ok(result);


        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internet server error {ex.Message}");
        }
    }
}

