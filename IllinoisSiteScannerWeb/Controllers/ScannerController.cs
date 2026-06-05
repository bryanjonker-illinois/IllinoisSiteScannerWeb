using IllinoisSiteScannerWeb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace IllinoisSiteScannerWeb.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ScannerController : ControllerBase {
        [AllowAnonymous]
        [DisableCors]
        public async Task<IActionResult> Index(string url) {
            var result = await WebsiteManager.Load(url);
            return new JsonResult(result);
        }
    }
}
