using System.Collections.Generic;

namespace UnitTests
{
    public interface ICommentDao
    {
        ICollection<Comment> LoadByPostTitle(string postTitle);
    }
}