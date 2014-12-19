using System.Data.Entity;

namespace UnitTests
{
    public class BlogContext : DbContext
    {
        //public BlogContext() : base("defaultSqlConnection")
        //{
            
        //}

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
    }
}