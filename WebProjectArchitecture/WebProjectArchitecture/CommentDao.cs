using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace WebProjectArchitecture
{
    public class CommentDao : ICommentDao
    {
        public CommentDao()
        {
            
        }
        public ICollection<Comment> LoadByPostTitle(string postTitle)
        {
            var result = new Collection<Comment>();
            var commentsCount = new Random().Next(0, 100);
            for (int i = 0; i < commentsCount; i++)
            {
                result.Add(new Comment());
            }

            return result;
        }
    }
}