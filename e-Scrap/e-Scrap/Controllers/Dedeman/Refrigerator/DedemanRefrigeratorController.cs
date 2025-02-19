﻿using Microsoft.AspNetCore.Mvc;
using Models.Common.Refrigerator;
using Services.Dedeman.Refrigerator;

namespace Controllers.Dedeman.Refrigerator
{
    [ApiController]
    [Route("api/dedeman")]
    public class DedemanRefrigeratorController : ControllerBase
    {
        private readonly IDedemanRefrigeratorService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public DedemanRefrigeratorController(IDedemanRefrigeratorService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("refrigerator")]
        public async Task<ActionResult<List<RefrigeratorModel>>> ScrapeRefrigeratorProducts()
        {
            List<RefrigeratorModel> result = await _scrapService.GetAltexRefrigerator();

            // Check if the result is null or empty
            if (result == null || result.Count == 0)
            {
                return NotFound("No products found.");
            }

            // Return the list of products
            return Ok(result);
        }
    }
}
