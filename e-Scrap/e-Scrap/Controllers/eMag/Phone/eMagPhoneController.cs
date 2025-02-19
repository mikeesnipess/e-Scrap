﻿using e_Scrap.Models.Common.Phone;
using eScrap.Services.eMag.Phone;
using Microsoft.AspNetCore.Mvc;

namespace eScrap.Controllers.eMag.Phone
{
    [ApiController]
    [Route("api/emag")]
    public class eMagPhoneController : ControllerBase
    {
        private readonly IEmagPhoneService _emagPhoneService;
        private readonly IAppSettingsDbContext _context;

        public eMagPhoneController(IEmagPhoneService emagPhoneService, IAppSettingsDbContext context)
        {
            _emagPhoneService = emagPhoneService;
            _context = context;
        }

        [HttpGet("phone")]
        public async Task<ActionResult<List<PhoneModel>>> ScrapePhoneProducts()
        {
            List<PhoneModel> result = await _emagPhoneService.GetEmagPhones();
            if (result == null || result.Count == 0)
            {
                return NotFound("No products found.");
            }

            return Ok(result);
        }
    }
}
