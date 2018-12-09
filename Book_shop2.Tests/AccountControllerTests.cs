using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;
using Book_shop2.Controllers;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;
using Book_shop2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Moq;

namespace Book_shop2.Tests
{
    public class AccountControllerTests
    {
        [Fact]
        public void Correct_Login_And_Redirect()
        {
            // Arrange
            MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var mock = new Mock<IRepository>();
            var controller = new AccountController(_db, mock.Object);
            var loginModel = new LoginModel
            {
                Name = "Павел",
                Password = "Pavel123"
            };

            // Act
            var result = controller.Login(loginModel);

            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Books", redirectResult?.ActionName);
        }
        
        [Theory]
        [InlineData("Павел", "Pavel123a")]
        [InlineData("Олег", "Oleg2")]
        [InlineData("Дмитрий", "Dmitry3")]
        [InlineData("Аркадий", "abcde")]
        [InlineData("Елена", "123456")]
        public void Not_Correct_User_Do_Not_Login(string name, string password)
        {
            // Arrange
            MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var mock = new Mock<IRepository>();
            var controller = new AccountController(_db, mock.Object);
            var loginModel = new LoginModel
            {
                Name = name,
                Password = password
            };
            
            // Act
            var result = controller.Login(loginModel);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }


        [Theory]
        [InlineData("", "Pavel123a")]
        [InlineData("Олег", "")]
        public void Do_Not_Login_With_NoValid_Model(string name, string password)
        {
            // Arrange
            var mock = new Mock<IRepository>();
            MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var controller = new AccountController(_db, mock.Object);
            var currentUser = new user();
            var loginModel = new LoginModel
            {
                Name = name,
                Password = password
            };
            
            
            // Act
            var result = controller.Login(loginModel);


            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotEqual(currentUser, viewResult?.Model);
            
        }
    }
}