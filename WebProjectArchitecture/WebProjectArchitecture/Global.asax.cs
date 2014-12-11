using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DryIoc;
using WebProjectArchitecture.Controllers;

namespace WebProjectArchitecture
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static readonly Container Container = new Container();

        protected void Application_Start()
        {
            Container.Register<ICommentDao, CommentDao>(Reuse.Transient);
            Container.Register<IPostDao, PostDao>(Reuse.Transient);
            Container.Register<ILogger, Logger>(Reuse.Transient);
            Container.Register<IPostPresentationService, PostPresentationService>(Reuse.Singleton);
            Container.Register<HomeController, HomeController>();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(typeof(MyControllerFactory));
        }
    }
}
