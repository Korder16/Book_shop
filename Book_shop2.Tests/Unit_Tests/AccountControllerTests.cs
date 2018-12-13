using Moq;
using Xunit;
using Book_shop2.Models;
using Book_shop2.ViewModels;
using Book_shop2.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Book_shop2.Helpers.IRepositories;

namespace Book_shop2.Tests.Unit_Tests
{
    public class AccountControllerTests
    {
        [Theory]
        [InlineData("Павел", "Pavel123")]
        [InlineData("Игорь", "Igor123")]
        public void Correct_Login_And_Redirect(string name, string password)
        {
            // Arrange
            MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var mock = new Mock<IUserRepository>();
            var controller = new AccountController(_db, mock.Object);
            var loginModel = new LoginModel
            {
                Name = name,
                Password = password
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
            var mock = new Mock<IUserRepository>();
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
        [InlineData("", "")]
        public void Do_Not_Login_With_NoValid_Model(string name, string password)
        {
            // Arrange
            var mock = new Mock<IUserRepository>();
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


        [Theory]
        [InlineData("Владимир", "Vlad", "VVlad", "vlad@mail.ru", "Работает")]
        [InlineData("Антон", "Anton111", "Anton111", "anton", "Не работает")]
        [InlineData("", "", "", "", "")]
        public void Do_Not_Register_With_NoValid_Model(string name, string password, 
            string confirmPassword, string email, string activity)
        {
            // Arrange
            MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var mock = new Mock<IUserRepository>();
            var controller = new AccountController(_db, mock.Object);
            controller.ModelState.AddModelError("Name", "Required");
            RegisterModel newUser = new RegisterModel();
            var registerModel = new RegisterModel
            {
                Name = name,
                Password = password,
                ConfirmPassword = confirmPassword,
                Email = email,
                Activity = activity
            };

            // Act
            var result = controller.Register(registerModel);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotEqual(newUser, viewResult?.Model);
        }
    }
}