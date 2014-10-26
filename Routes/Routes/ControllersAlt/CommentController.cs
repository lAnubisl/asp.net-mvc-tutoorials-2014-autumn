using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Routes.Models;

namespace Routes.Controllers
{
    [RoutePrefix("Comment")]
    public class CommentController : Controller
    {
        [Route("")]
        public ContentResult Index()
        {
            return new ContentResult() { Content = "Hello world" };
        }

        [Route("Recent")]
        public ActionResult Recent()
        {
            var model = new RecentDataModel();
            return View(model);
        }

        [Route("ById/{id}")]
        public ContentResult ByID(int id)
        {
            return new ContentResult() { Content = "This is a comment #" + id };
        }
    }
}
