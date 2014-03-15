using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layouts.Controllers
{
    public class HomeController : Controller
    {
        public RedirectToRouteResult Index()
        {
            return RedirectToAction("Cats");
        }

        public ActionResult Cats()
        {
            return View();
        }

        public ActionResult Dogs()
        {
            return View();
        }
	}
}