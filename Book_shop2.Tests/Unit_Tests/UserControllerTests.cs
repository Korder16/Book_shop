using System.Collections.Generic;
using System.Linq;
using Book_shop2.Controllers;
using Book_shop2.Helpers.IRepositories;
using Book_shop2.Models;
using Book_shop2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace Book_shop2.Tests.Unit_Tests
{
    public class UserControllerTests
    {
        private MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());

        [Fact]
        public void Users_Correct_View_Page()
        {
            // Arrange
            var mock = new Mock<IUserRepository>();
            mock.Setup(repo => repo.GetAllUsers()).Returns(GetUsers());
            var controller = new UserController(_db, mock.Object);
            
            // Act
            var result = controller.Users();
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<user>>(viewResult.Model);
            Assert.Equal(GetUsers().Count, model.Count());
        }
        
        private List<user> GetUsers()
        {
            MyBookShopContext db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var users = new List<user>(db.Users);
            return users;
        }
        
        
        [Theory]
        [InlineData(1, "Иван", "ivan@mail.ru", "Работает", 1)]
        [InlineData(2, "Павел", "pavel@mail.ru", "Работает", 2)]
        [InlineData(3, "Игорь", "igor@mail.ru", "Работает", 2)]
        [InlineData(18, "Миронов Максим Олегович", "maxim@mail.ru", "Работает", 1)]
        public void Edit_User_Redirects_And_EditUser(int testUserId, string name, string email, string activity, int role_id)
        {
            // Arrange
            var mock = new Mock<IUserRepository>();
            mock.Setup(repo => repo.GetUser(testUserId))
                .Returns(GetUsers().FirstOrDefault(user => user.Id == testUserId));
            var controller = new UserController(_db, mock.Object);
            
            // Act
            var result = controller.EditUser(testUserId);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<EditUserModel>(viewResult.ViewData.Model);
            Assert.Equal(name, model.Name);
            Assert.Equal(email, model.Email);
            Assert.Equal(activity, model.Activity);
            Assert.Equal(role_id, model.RoleId);
        }
    }
}