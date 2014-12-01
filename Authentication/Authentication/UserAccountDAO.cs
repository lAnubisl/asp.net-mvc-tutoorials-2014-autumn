using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Authentication
{
    public class UserAccountDao
    {
        public UserAccount GetUserAccount(string UserName)
        {
            return new UserAccount()
            {
                UserName =  UserName, 
                Password = "SecretString",
                Roles = new [] {"Administrator"}
            };
        }
    }
}