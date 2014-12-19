using System.Collections.Generic;

namespace UnitTests
{
    public interface IPostDao
    {
        ICollection<Post> Load(int skip, int take);

        Post Load(string title);
    }
}