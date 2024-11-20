﻿using e.Services.Altex;
using Microsoft.AspNetCore.Mvc;
using Models.Altex;

[ApiController]
[Route("[controller]")]
public class AltexGasCookerController : ControllerBase
{
    private readonly AltexGasCookerService _scrapService;
    private readonly AppSettingsDbContext _context;

    public AltexGasCookerController(AppSettingsDbContext context,AltexGasCookerService scrapService)
    {
        _context = context;
        _scrapService = scrapService;
    }

    [HttpGet("ScrapeGasCookerAltexProducts")]
    public async Task<ActionResult<List<AltexProductsModel>>> ScrapGasCookerProducts()
    {
        try
        {
            List<AltexProductsModel> result = await _scrapService.GetGasCookerAltex();

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

