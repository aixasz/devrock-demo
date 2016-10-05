using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Controllers;
using Xunit;

namespace WebApplication.Test
{

    public class TestHomeController
    { 
        [Fact]
        public void TestHomeController_HaveViewBagMessage()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal("Hello World", viewResult.ViewData["Message"]);
        }
    }
}
