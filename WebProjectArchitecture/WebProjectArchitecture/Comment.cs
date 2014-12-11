using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjectArchitecture
{
    public class Comment
    {
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public User Author { get; set; }
    }
}