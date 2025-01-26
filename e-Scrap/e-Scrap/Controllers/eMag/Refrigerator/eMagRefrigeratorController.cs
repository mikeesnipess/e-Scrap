using Microsoft.AspNetCore.Mvc;
using Models.Common.Refrigerator;
using Services.eMag.Refrigerator;

[ApiController]
[Route("api/emag")]
public class eMagRefrigeratorController : ControllerBase
{
    private readonly IEmagRefrigeratorService _scrapService;
    private readonly IAppSettingsDbContext _context;

    public eMagRefrigeratorController(IAppSettingsDbContext context, IEmagRefrigeratorService scrapService)
    {
        _context = context;
        _scrapService = scrapService;
    }

    [HttpGet("refrigerator")]
    public async Task<ActionResult<List<RefrigeratorModel>>> ScrapRefrigeratorProducts()
    {
        List<RefrigeratorModel> result = await _scrapService.GetRefrigeratorProducts();

        // Check if the result is null or empty
        if (result == null || result.Count == 0)
        {
            return NotFound("No products found.");
        }

        // Return the list of products
        return Ok(result);
    }
}
