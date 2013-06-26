using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Service;

namespace MyWebSite.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReferentialService _service;

        public HomeController(IReferentialService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(_service.GetAllEntities());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
