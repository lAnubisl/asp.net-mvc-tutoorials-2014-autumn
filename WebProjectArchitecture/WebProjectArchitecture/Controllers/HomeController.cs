using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProjectArchitecture.Models;

namespace WebProjectArchitecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostPresentationService service;
        // GET: Home

        public HomeController(IPostPresentationService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            return View(service.GetItems(15));
        }
    }
}