using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Routes.Models;

namespace Routes.Controllers
{
    public class CommentController : Controller
    {
        public ContentResult Index()
        {
            return new ContentResult() { Content = "Hello world" };
        }

        public ActionResult Recent()
        {
            var model = new RecentDataModel();
            return View(model);
        }

        public ContentResult ByID(int id)
        {
            return new ContentResult() { Content = "This is a comment #" + id };
        }
    }
}
