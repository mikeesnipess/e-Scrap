using e_Scrap.Models.Common.GasCooker;
using Microsoft.AspNetCore.Mvc;
using Services.eMag.GasCoooker;

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

    [HttpGet("eMagGasCooker")]
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

    [HttpGet("eMagGasCookerEmbbeded")]
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


    [HttpGet("eMagOvenEmbbeded")]
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

    [HttpGet("eMagHood")]
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
