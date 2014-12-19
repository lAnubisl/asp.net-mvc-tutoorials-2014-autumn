using System;
using System.Collections.Generic;

namespace UnitTests
{
    public class Post
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual User Author { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}