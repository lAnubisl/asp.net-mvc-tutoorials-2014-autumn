using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace UnitTests
{
    public class CommentDao : ICommentDao
    {
        private readonly IRepository<Comment> repository;

        public CommentDao(IRepository<Comment> repository)
        {
            this.repository = repository;
        }

        public ICollection<Comment> LoadByPostTitle(string postTitle)
        {
            return repository.Query().Where(c => c.Post.Title == postTitle).ToList();
        }
    }
}