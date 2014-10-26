using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Routes.Models;

namespace Routes.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            var model = new ArticleModel();
            return View(model);
        }

        //public ActionResult Index(int? id)
        //{
        //    var model = new ArticleModel();
        //    return View(model);
        //}

        //public ActionResult Index(int id = 0)
        //{
        //    var model = new ArticleModel();
        //    return View(model);
        //}

        //public ActionResult Index(int id)
        //{
        //    var model = new ArticleModel();
        //    return View(model);
        //}

        //public ActionResult Index(string id)
        //{
        //    var model = new ArticleModel();
        //    return View(model);
        //}
    }
}
