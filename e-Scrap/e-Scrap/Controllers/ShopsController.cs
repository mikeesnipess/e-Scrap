using e_Scrap.Models;
using eScrap.Services;
using Microsoft.AspNetCore.Mvc;

namespace e_Scrap.Controllers
{
    [ApiController]
    [Route("api/shop")]
    public class ShopsController : Controller
    {
        private readonly IAppSettingsDbContext _context;
        private readonly IShopService _shopsService;
        public ShopsController(IAppSettingsDbContext context, IShopService shopsService)
        {
            _context = context;
            _shopsService = shopsService;
        }
        [HttpGet]

        public async Task<ActionResult<List<ShopsModel>>> GetShops()
        {
            List<ShopsModel> result = await _shopsService.GetShopsModel();

            if (result == null || result.Count == 0)
            {
                return NotFound("No products found.");
            }

            return Ok(result);
        }
    }
}
