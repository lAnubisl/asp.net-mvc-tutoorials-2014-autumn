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

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            //...
        }
    }
}