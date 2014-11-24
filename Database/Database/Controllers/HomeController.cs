using System.Web.Mvc;
using Database.Models;
using System.Collections.ObjectModel;
using FormValidation.Repository;
using Database.Repository;
using System.Linq;
using Database.Repository.Domain;

namespace Database.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(string title)
        {
            if (title == null)
            {
                title = "This is my first title";
            }

            using (var ctx = new EFContext())
            {
                var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                var postModel = new PostModel(post.Title, post.Body, post.DateCreated);
                var commentModel = new Collection<string>();
                if (post.Comments != null && post.Comments.Any())
                {
                    foreach (var item in post.Comments)
	                {
                        commentModel.Add(item.Body);
	                }
                }

                var dao = new MongoDAO();
                var mPost = dao.LoadPost(title);

                return View(new ArticleModel(postModel, commentModel));
            }
            
            //var readers = new NewDataReaders();
            //return View(readers.GetArticleModel(title));
        }

        [HttpPost]
        public ActionResult Index(ArticleModel model)
        {
            var title = "This is my first title";

            if (model.NewComment != null && ModelState.IsValid)
            {

                using (var ctx = new EFContext())
                {
                    var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                    if (post != null)
                    {
                        ctx.Comments.Add(new Comment() { Body = model.NewComment.Comment, PostID = post.PostID });
                        ctx.SaveChanges();
                    }
                }
                //var readers = new NewDataReaders();
                //readers.AddComment(title, model.NewComment.Comment);
                //CommentsRepository.Comments.Add(model.NewComment.Comment);
                ModelState.Clear();
                return RedirectToAction("Index", new { title = title });
            }

            return View(model);
        }
    }
}