using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lektion8.Controllers;
using System.Web.Mvc;

namespace Lektion8Test
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void HomeController_IndexShouldReturnView()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
