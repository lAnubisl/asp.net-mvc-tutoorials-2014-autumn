using System;
using System.Security.Principal;
using System.Web;
using System.Web.Routing;
using System.Web.Security;

namespace Authentication
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    if (HttpContext.Current.User.Identity is FormsIdentity)
                    {
                        FormsIdentity id =
                            (FormsIdentity)HttpContext.Current.User.Identity;

                        var dao = new UserAccountDao();
                        var user = dao.GetUserAccount(id.Name);
                        if (user == null)
                        {
                            HttpContext.Current.User = null;
                        }
                        else
                        {
                            HttpContext.Current.Items[CurrentUserService.CurrentUserKey] = user;
                            HttpContext.Current.User = new GenericPrincipal(id, user.Roles);
                        }
                    }
                }
            }
        }
    }
}