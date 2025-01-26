using e_Scrap.Models.Common.Phone;
using Microsoft.AspNetCore.Mvc;
using Services.Altex.Phone;

namespace eScrap.Controllers.Altex.Phone
{
    [ApiController]
    [Route("api/altex")]
    public class AltexPhoneController : ControllerBase
    {
        private readonly IAltexPhoneService _scrapService;
        private readonly IAppSettingsDbContext _context;

        public AltexPhoneController(IAltexPhoneService scrapService, IAppSettingsDbContext context)
        {
            _scrapService = scrapService;
            _context = context;
        }

        [HttpGet("phone")]
        public async Task<ActionResult<List<PhoneModel>>> ScrapPhoneProducts()
        {
            List<PhoneModel> result = await _scrapService.GetPhoneListAsync();

            if (result == null || result.Count == 0)
            {
                return NotFound("No products found.");
            }

            return Ok(result);
        }
    }
}
