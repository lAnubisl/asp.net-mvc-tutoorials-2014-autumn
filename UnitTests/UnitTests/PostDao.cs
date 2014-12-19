using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnitTests
{
    public class PostDao : IPostDao
    {
        private const string loremIpsum =
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public ICollection<Post> Load(int skip, int take)
        {
            var result = new Collection<Post>();
            for (int i = 0; i < take; i++)
            {
                result.Add(new Post {Body = loremIpsum, DateCreated = DateTime.Now.AddDays(-1), Title = "Title " + i});
            }
            return result;
        }

        public Post Load(string title)
        {
            throw new NotImplementedException();
        }
    }
}