using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WebProjectArchitecture
{
    public class Post
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public User Author { get; set; }
        public ICollection<Comment> Comments { get; set; } 
    }
}