using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Forms.Models;
using Forms.Models.Binders;

namespace Forms
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //ModelBinders.Binders.Add(typeof(AddCommentModel), new MyModelBinder());
        }
    }
}