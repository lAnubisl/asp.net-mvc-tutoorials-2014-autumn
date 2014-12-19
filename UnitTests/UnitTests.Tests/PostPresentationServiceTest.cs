using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTests.Models;

namespace UnitTests.Tests
{
    [TestClass]
    public class PostPresentationServiceTest
    {
        [TestMethod]
        public void GetItems_Should_Return_The_Same_Items_Count_As_In_Data_Storage()
        {
            //Arrange
            var postDao = new Mock<IPostDao>();
            var posts = new Collection<Post>()
            {
                new Post(),
                new Post()
            };

            postDao.Setup(d => d.Load(It.IsAny<int>(), It.IsAny<int>())).Returns(posts);

            var commentDao = new Mock<ICommentDao>();
            var logger = new Mock<ILogger>();

            var service = new PostPresentationService(postDao.Object, commentDao.Object, logger.Object);


            //Act
            var model = service.GetItems(10);

            //Assert
            Assert.IsNotNull(model);
            Assert.AreEqual(2, model.Count);
        }

        [TestMethod]
        public void GetItem_Should_Return_Item_When_Item_Exists_In_Data_storage()
        {
            var postDao = new Mock<IPostDao>();
            var post = new Post() {Title = "MatchedTitle"};
            postDao.Setup(d => d.Load("MatchedTitle")).Returns(post);
            var commentDao = new Mock<ICommentDao>();
            var logger = new Mock<ILogger>();
            var service = new PostPresentationService(postDao.Object, commentDao.Object, logger.Object);

            var model = service.GetItem("MatchedTitle");

            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void GetItems()
        {
            var logger = new Mock<ILogger>();
            var commentDao = new Mock<ICommentDao>();
            var postDao = new Mock<IPostDao>();

            postDao.Setup(d => d.Load(It.IsAny<int>(), It.IsAny<int>())).Returns(null as ICollection<Post>);

            var service = new PostPresentationService(postDao.Object, commentDao.Object, logger.Object);
            var result = service.GetItems(1);

            logger.Verify(l => l.Error("PostDao returned null;"));
            Assert.IsNotNull(result);
        }
    }
}
