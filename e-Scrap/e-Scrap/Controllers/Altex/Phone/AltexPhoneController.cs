using e_Scrap.Models.Common.Phone;
using Microsoft.AspNetCore.Mvc;
using Services.Altex.Phone;

namespace eScrap.Controllers.Altex.Phone
{
    [ApiController]
    [Route("[controller]")]
    public class AltexPhoneController : ControllerBase
    {
        private readonly IAltexPhoneService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public AltexPhoneController(IAltexPhoneService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("ScrapeAltexPhone")]
        public async Task<ActionResult<List<PhoneModel>>> ScrapPhoneProducts()
        {
            try
            {
                List<PhoneModel> result = await _scrapService.GetPhoneListAsync();

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
}
