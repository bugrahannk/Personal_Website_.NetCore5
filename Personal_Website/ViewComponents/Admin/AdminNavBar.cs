using Microsoft.AspNetCore.Mvc;

namespace Personal_Website.ViewComponents.Admin {
    public class AdminNavBar:ViewComponent {
        public IViewComponentResult Invoke() {
            return View();
        }
    }
}
