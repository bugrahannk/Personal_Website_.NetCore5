using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Personal_Website.Controllers {
    public class PortfolioController : Controller {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index() {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Listesi";
            var values = portfolioManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddPortfolio() {
            return View();
        }


        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio) {

            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Ekleme";

            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }

        

    }
}
