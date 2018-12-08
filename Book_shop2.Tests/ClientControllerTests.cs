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
        
        public void ClassInitialize()
        {
            var mock = new Mock<IRepository>();
            var controller = new ClientController(mock.Object);
        }
        
        
        [TestMethod]
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

        [Fact]
        public void Create_Client_Redirects_And_AddClient()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            var controller = new ClientController(mock.Object);
            client newClient = new client()
            {
                Name = "Дмитрий Иванович",
                Phone = "8(800)555-35-35",
                Email = "dmitry@gmail.com",
                Adress = "г. Мсоква, ул. Тверская, д.12"
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

        [Fact]
        public void Edit_Client_Redirects_And_EditClient()
        {
            // Arrange
            int testClientId = 1;
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetClient(testClientId))
                .Returns(GetClients().FirstOrDefault(cli => cli.Id == testClientId));
            var controller = new ClientController(mock.Object);
            
            // Act
            var result = controller.EditClient(testClientId);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<client>(viewResult.ViewData.Model);
            Assert.Equal("Владмир", model.Name);
            Assert.Equal("8(929)666-33-22", model.Phone);
            Assert.Equal("vladimir@mail.ru", model.Email);
            Assert.Equal("г. Москва, ул. Покровская, 15", model.Adress);
        }
    }
}