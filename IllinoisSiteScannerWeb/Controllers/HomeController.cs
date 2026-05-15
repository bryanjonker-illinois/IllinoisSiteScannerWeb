using IllinoisSiteScannerWeb.Data;
using IllinoisSiteScannerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IllinoisSiteScannerWeb.Controllers {
    public class HomeController : Controller {
        public async Task<IActionResult> Index(string url) {
            return View(new IndexModel { WebsiteInformation = await WebsiteManager.Load(url) });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
