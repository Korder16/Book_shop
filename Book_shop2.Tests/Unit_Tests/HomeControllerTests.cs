using System.Collections.Generic;
using System.Linq;
using Book_shop2.Controllers;
using Book_shop2.Helpers;
using Book_shop2.Helpers.IRepositories;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace Book_shop2.Tests.Unit_Tests
{
    public class HomeControllerTests
    {
        private MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());

        [Fact]
        public void Statistics_Correct_View_Page()
        {
            // Arrange
            var mock = new Mock<IHomeRepository>();
            var controller = new HomeController(_db, mock.Object);
            
            // Act
            var result = controller.Statistics();
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }
    }
}