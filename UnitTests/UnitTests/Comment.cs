using System;

namespace UnitTests
{
    public class Comment
    {
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual User Author { get; set; }
        public virtual Post Post { get; set; }
    }
}