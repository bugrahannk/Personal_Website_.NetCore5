﻿using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;

namespace Personal_Website.ViewComponents.Service {
    public class ServiceList : ViewComponent {

        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke() {
            var values = serviceManager.TGetList();
            return View(values);
        }
    }
}
