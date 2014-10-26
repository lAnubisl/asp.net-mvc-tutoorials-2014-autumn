using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routes.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult Index()
        {
            return new ContentResult() { Content = "Administrative Area"};
        }
    }
}
