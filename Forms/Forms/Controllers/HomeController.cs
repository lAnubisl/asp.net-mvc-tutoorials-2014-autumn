using System.Web.Mvc;
using Forms.Models;
using Forms.Models.Binders;
using Forms.Repository;

namespace Forms.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult AddComment()
        //{
        //    string comment = Request.Form["Comment"];
        //    return RedirectToAction("Index", "Home");
        //}

        //public ActionResult AddComment(string Comment)
        //{
        //    return RedirectToAction("Index", "Home");
        //}

        //[HttpPost]
        //public ActionResult AddComment(AddCommentModel model)
        //{
        //    return RedirectToAction("index", "home");
        //}

        //[HttpPost]
        //public ActionResult AddComment(AddCommentModel model)
        //{
        //    return RedirectToAction("Index", "Home");
        //}

        [HttpGet]
        public ActionResult Index()
        {
            string query = Request.QueryString["Foo"];
            var model = new ArticleModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(AddCommentModel model)
        {
            if (model.User != null && model.User.Avatar != null && model.User.Avatar.ContentLength > 0)
            {
                model.User.Avatar.SaveAs("C:/Users/Alexander/Documents/Temp/" + model.User.Avatar.FileName);
            }
            if (!string.IsNullOrWhiteSpace(model.Comment)){
                CommentsRepository.Comments.Add(model.Comment);
            }
            
            return View(new ArticleModel());
        }

    }
}