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
            Session["sessionKey"] = new UserAccount() {UserName = "TempUserName"};

            var ticker = new FormsAuthenticationTicket(2, "Alex", DateTime.Now, DateTime.Now.AddMonths(1), true,
                String.Empty);
            var encTicket = FormsAuthentication.Encrypt(ticker);

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
            cookie.Expires = DateTime.Now.AddMonths(1);

            Response.Cookies.Add(cookie);

            return View(new ArticleModel());
        }

        [HttpPost]
        [MyAuthorizeAttribte]
        public ActionResult Index(ArticleModel model)
        {
            var userAccount = Session["sessionKey"] as UserAccount;

            if (model.NewComment != null && ModelState.IsValid)
            {
                CommentsRepository.Comments.Add(model.NewComment.Comment);
                ModelState.Clear();
            }

            return View(model);
        }
    }
}