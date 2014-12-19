using System.Web.Mvc;

namespace UnitTests.Controllers
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