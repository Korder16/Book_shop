using System.Collections.Generic;
using System.Linq;
using Book_shop2.Controllers;
using Book_shop2.Helpers.IRepositories;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace Book_shop2.Tests.Unit_Tests
{
    public class ProviderControllerTests
    {
        private MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());

        [Fact]
        public void Orders_Correct_View_Page()
        {
            // Arrange
            var mock = new Mock<IProviderRepository>();
            mock.Setup(repo => repo.GetAllProviders()).Returns(GetProviders());
            var controller = new ProviderController(_db, mock.Object);
            
            // Act
            var result = controller.Providers();
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<provider>>(viewResult.Model);
            Assert.Equal(GetProviders().Count, model.Count());
        }
        
        private List<provider> GetProviders()
        {
            MyBookShopContext db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var providers = new List<provider>(db.Providers);
            return providers;
        }

        [Theory]
        [InlineData("Канцопт", "Владимир", "8(999)999-99-99", "kanz@mail.ru")]
        [InlineData("Новые книги", "Москва", "8(916)123-49-96", "newbooks@mail.ru")]
        [InlineData("МегаМаг", "Москва", "8(929)239-78-99", "mega@mail.ru")]
        public void Create_Provider_Redirects_And_AddProvider(string name, string city, string phone, string email)
        {
            // Arrange
            var mock = new Mock<IProviderRepository>();
            var controller = new ProviderController(_db, mock.Object);
            provider newProvider = new provider()
            {
                Name = name,
                City = city,
                Phone = phone,
                Email = email
            };
            
            // Act
            var result = controller.CreateProvider(newProvider);

            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Providers", redirectResult?.ActionName);
        }
        
        [Theory]
        [InlineData("", "Владимир", "8(999)999-99-99", "kanz@mail.ru")]
        [InlineData("Новые книги", "", "8(916)123-49-96", "newbooks@mail.ru")]
        [InlineData("МегаМаг", "Москва", "8929239-78-99", "mega@mail.ru")]
        [InlineData("МегаМаг", "Москва", "8929239-78-99", "")]
        [InlineData("МегаМаг", "Москва", "", "mega@mail.ru")]
        public void DoNot_Create_Provider_With_NoValid_Model(string name, string city, string phone, string email)
        {
            // Arrange
            var mock = new Mock<IProviderRepository>();
            var controller = new ProviderController(_db, mock.Object);
            controller.ModelState.AddModelError("Name", "Required");
            provider newProvider = new provider()
            {
                Name = name,
                City = city,
                Phone = phone,
                Email = email
            };
            
            // Act
            var result = controller.CreateProvider(newProvider);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(newProvider, viewResult?.Model);
        }
    }
}