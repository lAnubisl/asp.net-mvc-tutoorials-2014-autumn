using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.Tests
{
    [TestClass]
    public class CommentDaoTest
    {
        [TestMethod]
        public void LoadByPostTitle_Should_Return_Comments_By_Post_Title()
        {
            var repository = new Mock<IRepository<Comment>>();
            var comments = new List<Comment>()
            {
                new Comment() {Body = "Matched", Post = new Post() {Title = "MatchedTitle"}},
                new Comment() {Body = "NotMatched", Post = new Post() {Title = "NotMatchedTitle"}}
            };
            repository.Setup(r => r.Query()).Returns(comments.AsQueryable());

            var commentDao = new CommentDao(repository.Object);
            var result = commentDao.LoadByPostTitle("MatchedTitle");
            
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual("Matched", result.First().Body);
        }
    }
}
