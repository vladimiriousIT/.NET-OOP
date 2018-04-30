using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "SportsBettings Description";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        public ActionResult Preview()
        {
            ViewBag.Message = "Preview";

            return View();
        }
        public ActionResult Edit()
        {
            ViewBag.Message = "Edit Mode";

            return View();
        }
    }
}