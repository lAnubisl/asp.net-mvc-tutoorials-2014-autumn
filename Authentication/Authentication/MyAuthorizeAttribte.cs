using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authentication
{
    public class MyAuthorizeAttribte : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var service = new CurrentUserService();
            var user = service.GetCurentUser();
            if (user == null)
            {
                return false;
            }

            return user.UserName.StartsWith("A");
        }
    }
}