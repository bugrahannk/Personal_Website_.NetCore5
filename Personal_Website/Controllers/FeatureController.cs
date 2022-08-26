using Microsoft.AspNetCore.Mvc;

namespace Personal_Website.Controllers {
    public class FeatureController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
