using TestWebApp.Controllers; // Update with your actual namespace
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace TestWebApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
