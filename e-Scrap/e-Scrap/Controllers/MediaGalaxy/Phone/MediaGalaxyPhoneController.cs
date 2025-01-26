using e_Scrap.Models.Common.Phone;
using eScrap.Services.MediaGalaxy.Phone;
using Microsoft.AspNetCore.Mvc;

namespace eScrap.Controllers.MediaGalaxy.Phone
{
    [ApiController]
    [Route("api/media-galaxy")]
    public class MediaGalaxyPhoneController : ControllerBase
    {
        private readonly IMediaGalaxyPhoneService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public MediaGalaxyPhoneController(IMediaGalaxyPhoneService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("phone")]
        public async Task<ActionResult<List<PhoneModel>>> ScrapPhoneProducts()
        {
            try
            {
                List<PhoneModel> result = await _scrapService.GetProductListAsync();
                if (result == null || result.Count == 0)
                {
                    return NotFound("No products found...");
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
