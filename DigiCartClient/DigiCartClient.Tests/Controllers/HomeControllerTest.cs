using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigiCartClient;
using DigiCartClient.Controllers;
using DigiCartClient.Interfaces;
using Moq;

namespace DigiCartClient.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        // private readonly IProductService _productService;

        [TestMethod]
        public void Index()
        {
            var _productService = new Mock<IProductService>();

            _productService.Setup(m => m.IsProductExpired("ACX123")).Returns(true);
            // Arrange
            HomeController controller = new HomeController(_productService.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewBag.IsProductExpired, true);

        }

    }
}
