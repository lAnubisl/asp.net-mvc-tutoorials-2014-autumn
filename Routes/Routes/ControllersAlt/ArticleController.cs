using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Routes.Models;

namespace Routes.Controllers
{
    [RoutePrefix("Article")]
    public class ArticleController : Controller
    {
        [Route("")]
        public ContentResult Index()
        {
            return new ContentResult() { Content = "Hello world" };
        }

        [Route("~/Article-{seoUrl:maxlength(3)?}")]
        public ContentResult GetByUrl(string seoUrl)
        {
            return new ContentResult() { Content = "#" + seoUrl + "#" };
        }
        
        [Route("Recent")]
        public ActionResult Recent()
        {
            var model = new RecentDataModel();
            return View(model);
        }
    }
}
