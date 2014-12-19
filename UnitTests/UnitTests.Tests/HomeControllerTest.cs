using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTests.Controllers;
using UnitTests.Models;

namespace UnitTests.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_Should_Return_15_Items()
        {
            var service = new Mock<IPostPresentationService>();
            service.Setup(s => s.GetItems(It.IsAny<int>())).Returns(new Collection<PostItemViewModel>());
            var controller = new HomeController(service.Object);

            var result = controller.Index() as ViewResult;


            Assert.AreEqual(15, (result.Model as ICollection<PostItemViewModel>).Count);
        }
    }
}
