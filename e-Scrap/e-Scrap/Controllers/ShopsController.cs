using e_Scrap.Models;
using eScrap.Services;
using Microsoft.AspNetCore.Mvc;

namespace e_Scrap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopsController : Controller
    {
        private readonly IAppSettingsDbContext _context;
        private readonly IShopService _shopsService;
        public ShopsController(IAppSettingsDbContext context, IShopService shopsService)
        {
            _context = context;
            _shopsService = shopsService;
        }
        [HttpGet("getShops")]

        public async Task<ActionResult<List<ShopsModel>>> GetShops()
        {
            try
            {
                List<ShopsModel> result = await _shopsService.GetShopsModel();

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
