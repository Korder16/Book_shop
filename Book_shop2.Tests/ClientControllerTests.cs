using System;
using System.Collections.Generic;
using System.Linq;
using Book_shop2.Controllers;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using TestToolsToXunitProxy;
using Xunit;
using Assert = Xunit.Assert;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;


namespace Book_shop2.Tests
{
    [TestClass]
    public class ClientControllerTests
    {
        private MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
        [Fact]
        public void Clients_Correct_View_Page()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetAllClients()).Returns(GetClients());
            var controller = new ClientController(mock.Object);
            
            // Act
            var result = controller.Clients();
            
            // Assert
            // Является ли возвращаемый результат объектом ViewResult
            var viewResult = Assert.IsType<ViewResult>(result);
            
            // Передается ли в преставление IEnumrable<client>
            var model = Assert.IsAssignableFrom<IEnumerable<client>>(viewResult.Model);
            
            // Сравнивается количество обхектов, которые передаются в представление
            Assert.Equal(GetClients().Count, model.Count());
        }

        private List<client> GetClients()
        {
            MyBookShopContext db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var clients = new List<client>(db.Clients);
            return clients;
        }

        [Theory]
        [InlineData("Дмитрий Иванович", "8(800)526-35-35", "dmitry@gmail.com", "г. Моcква, ул. Тверская, д.12")]
        [InlineData("Иванов Иван Иванович", "8(800)123-32-35", "dmitry@gmail.com", "г. Моcква, ул. Пушкинская, д.3")]
        [InlineData("Иванов Алексей Иванович", "8(929)111-55-40", "alex@mail.com", "г. Моcква, Рубцовская наб., д.34")]
        [InlineData("Петров Егор Олегович", "8(800)555-35-35", "egor@gmail.com", "г. Моcква, ул. Чистые пруды, д.5")]
        public void Create_Client_Redirects_And_AddClient(string name, string phone, string email, string adress)
        {
            // Arrange
            var mock = new Mock<IRepository>();
            var controller = new ClientController(mock.Object);
            client newClient = new client()
            {
                Name = name,
                Phone = phone,
                Email = email,
                Adress = adress
            };
            
            // Act
            var result = controller.AddClient(newClient);

            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Clients", redirectResult?.ActionName);
        }

        [Fact]
        public void Create_Client_Returns_ViewResult_With_ClientModel()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            var controller = new ClientController(mock.Object);
            controller.ModelState.AddModelError("Name", "Required");
            client newClient = new client();
            
            // Act
            var result = controller.AddClient(newClient);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(newClient, viewResult?.Model);
            
        }

        [Theory]
        [InlineData(1, "Владмир", "8(929)666-33-22", "vladimir@mail.ru", "г. Москва, ул. Покровская, 15")]
        [InlineData(2, "Иванов Иван Иванович", "8(929)999-99-99", "ivanovii@mail.ru", "г. Москва, ул. Покровская, 9")]
        [InlineData(3, "Иванов Алексей Иванович", "8(916)123-23-35", "ivan@yandex.ru", "г. Москва, ул. Покровская, 17")]
        [InlineData(4, "Петров Егор Олегович", "8(800)555-35-35", "asdf@mail.ru", "г. Москва, ул. Покровская, 3")]
        public void Edit_Client_Redirects_And_EditClient(int testClientId, string name, string phone, string email, string adress)
        {
            // Arrange
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetClient(testClientId))
                .Returns(GetClients().FirstOrDefault(cli => cli.Id == testClientId));
            var controller = new ClientController(mock.Object);
            
            // Act
            var result = controller.EditClient(testClientId);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<client>(viewResult.ViewData.Model);
            Assert.Equal(name, model.Name);
            Assert.Equal(phone, model.Phone);
            Assert.Equal(email, model.Email);
            Assert.Equal(adress, model.Adress);
        }
    }
}