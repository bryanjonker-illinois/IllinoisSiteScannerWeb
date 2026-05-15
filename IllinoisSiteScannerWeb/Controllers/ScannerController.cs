using IllinoisSiteScannerWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace IllinoisSiteScannerWeb.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ScannerController : ControllerBase {
        public async Task<IActionResult> Index(string url) {
            var result = await WebsiteManager.Load(url);
            return new JsonResult(result);
        }
    }
}
