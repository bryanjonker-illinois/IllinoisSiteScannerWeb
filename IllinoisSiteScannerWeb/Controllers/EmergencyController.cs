using IllinoisSiteScannerWeb.Emergency;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace IllinoisSiteScannerWeb.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EmergencyController(EmergencyContainer container) : ControllerBase {

        private readonly EmergencyContainer _container = container;

        [AllowAnonymous]
        [DisableCors]
        public IActionResult Index() {
            var results = _container.Get();
            return string.IsNullOrWhiteSpace(results.Title) && string.IsNullOrWhiteSpace(results.Description) ?
                new JsonResult("") :
                new JsonResult(results);
        }

        [HttpGet("full")]
        [AllowAnonymous]
        [DisableCors]
        public IActionResult Time() => new JsonResult(_container.Get());

    }
}
