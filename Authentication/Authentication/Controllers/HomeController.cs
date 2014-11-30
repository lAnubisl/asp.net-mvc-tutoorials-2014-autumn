using System.Web.Mvc;
using Authentication.Models;
using FormValidation.Repository;
using System.Web;
using System;
using System.Web.Security;

namespace Authentication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new ArticleModel());
        }

        [HttpPost]
        public ActionResult Index(ArticleModel model)
        {
            if (model.NewComment != null && ModelState.IsValid)
            {
                CommentsRepository.Comments.Add(model.NewComment.Comment);
                ModelState.Clear();
            }

            return View(model);
        }
    }
}