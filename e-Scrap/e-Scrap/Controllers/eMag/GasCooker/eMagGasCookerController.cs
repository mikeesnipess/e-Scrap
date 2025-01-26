using e_Scrap.Models.Common.GasCooker;
using Microsoft.AspNetCore.Mvc;
using Services.eMag.GasCoooker;

[ApiController]
[Route("api/emag")]
public class eMagGasCookerController : ControllerBase
{
    private readonly IEmagGasCookerService _scrapService;
    private readonly IAppSettingsDbContext _context;

    public eMagGasCookerController(IAppSettingsDbContext context, IEmagGasCookerService scrapService)
    {
        _context = context;
        _scrapService = scrapService;
    }

    [HttpGet("gas-cooker")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapGasCookerProducts()
    {
        try
        {
            List<GasCookerModel> result = await _scrapService.GetGasCookerProducts();

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
    public async Task<ActionResult<List<GasCookerModel>>> ScrapeGasCoookerEmbeddedProducts()
    {
        try
        {
            List<GasCookerModel> result = await _scrapService.GetGasCookerEmbeddedProducts();
            if (result == null || result.Count == 0)
            {
                return NotFound("eMag GasCooker embedded products not found");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internet server error: {ex.Message}");
        }
    }


    [HttpGet("oven-embedded")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapeOvenEmbeddedProducts()
    {
        try
        {
            List<GasCookerModel> result = await _scrapService.GetOvenEmbeddedProducts();
            if (result == null || result.Count == 0)
            {
                return NotFound("eMag Oven embedded products not found");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internet server error: {ex.Message}");
        }
    }

    [HttpGet("hood")]
    public async Task<ActionResult<List<GasCookerModel>>> ScrapeHoodProducts()
    {
        try
        {
            List<GasCookerModel> result = await _scrapService.GetHoodProducts();
            if (result == null || result.Count == 0)
            {
                return NotFound("eMag Hood embedded products not found");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internet server error: {ex.Message}");
        }
    }
}
