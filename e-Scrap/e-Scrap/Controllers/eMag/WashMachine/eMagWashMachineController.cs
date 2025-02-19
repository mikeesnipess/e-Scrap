﻿using e_crap.Models.Common.WashMachine;
using Microsoft.AspNetCore.Mvc;
using Services.eMag.WashMachine;

namespace Controllers.eMag.WashMachine
{
    [ApiController]
    [Route("api/emag")]
    public class eMagWashMachineController : ControllerBase
    {
        private readonly IEmagWashMachineService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public eMagWashMachineController(IEmagWashMachineService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("wash-machine")]
        public async Task<ActionResult<List<WashMachineModel>>> ScrapGasCookerProducts()
        {
            List<WashMachineModel> result = await _scrapService.GetWashMachineEMag();

            if (result == null || result.Count == 0)
            {
                return NotFound("No products found.");
            }

            return Ok(result);
        }
    }
}
