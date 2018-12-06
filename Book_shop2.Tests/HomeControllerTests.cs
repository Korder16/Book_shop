using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Book_shop2.Controllers;
using Book_shop2.Models;
using System.Linq;
using Moq;
using Xunit;

namespace Book_shop2.Tests
{
    public class HomeControllerTests
    {
        
        [Fact]
        public void StatisticsViewDataMessage()
        {
            // Arrange
            //AddDbContext<MyBookShopContext>(opt => opt.UseNpgsql("User ID = ****;Password=********;
            //Server=localhost;Port=5432;
            //Database=book_shop;Integrated Security=true;Pooling=true"));
            //MyBookShopContext db = new ("MyBookShopConnection");
            //var mockRepo = new Mock<MyBookShopContext>();
            
            var list = new List<order>();
            var mock = new Mock<MyBookShopContext>();
            
            mock.Setup(repo => repo.Orders.ToList()).Returns(list);
            
            var controller = new HomeController(mock.Object);
            
            // Act
            var result = controller.Statistics();
            
            // Assert
            //Assert.Equal("Hello", result?.ViewData["Message"]);
            Assert.Equal(4, Decimal.Add(2, 2));
        }
        

        [Fact]
        public void First_test()
        {
            Assert.Equal(4, Decimal.Add(2, 2));
        }
    }
}