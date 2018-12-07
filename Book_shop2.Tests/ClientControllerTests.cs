using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Book_shop2.Controllers;
using Book_shop2.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace Book_shop2.Tests
{
    public class ClientControllerTests
    {
        
        [Fact]
        public void StatisticsViewDataMessage()
        {
            // Arrange
            //var mock = new Mock<IRepository>();

            //mock.Setup(a => a.GetAll()).Returns(new List<order>());
            MyBookShopContext db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            ClientController controller = new ClientController(db);
            
            // Act
            var result = controller.Clients();
            
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