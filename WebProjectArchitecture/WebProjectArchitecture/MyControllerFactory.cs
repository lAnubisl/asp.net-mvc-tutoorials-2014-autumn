using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DryIoc;

namespace WebProjectArchitecture
{
    public class MyControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (IController)MvcApplication.Container.Resolve(controllerType);
        }
    }
}