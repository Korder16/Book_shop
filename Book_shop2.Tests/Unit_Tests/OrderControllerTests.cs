using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Serialization;
using Book_shop2.Controllers;
using Book_shop2.Helpers.IRepositories;
using Book_shop2.Models;
using Book_shop2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;

namespace Book_shop2.Tests.Unit_Tests
{
    public class OrderControllerTests
    {
        private MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());

        [Fact]
        public void Orders_Correct_View_Page()
        {
            // Arrange
            var mock = new Mock<IOrderRepository>();
            var controller = new OrderController(_db, mock.Object);
            
            // Act
            var result = controller.Orders();
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }
        
        
        [Theory]
        [InlineData(1, 1, 1, 350, "01.01.2019", 5, "Максим")]
        [InlineData(4, 1, 1, 550, "01.01.2019", 7, "Егор")]
        public void Correct_Create_Order_And_Redirect(int book_id, int customer_id, int stuff_id, 
            int price, string date_to, int count, string courier)
        {
            // Arrange
            var mock = new Mock<IOrderRepository>();
            var controller = new OrderController(_db, mock.Object);
            OrderModel newOrder = new OrderModel()
            {
                BookId = book_id,
                CustomerId = customer_id,
                StuffId = stuff_id,
                Price = price,
                DateTo = date_to,
                Count = count,
                Courier = courier
            };
            
            // Act
            var result = controller.CreateOrder(newOrder);
            
            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Orders", redirectResult?.ActionName);
        }

        [Theory]
        [InlineData(1, 1, 1, 350, "", 5, "Максим")]
        [InlineData(4, 1, 1, 550, "01.01.2019", 7, "")]
        [InlineData(1, 1, 1, -1, "", 5, "")]
        public void DoNot_Create_Order_With_NoValid_Model(int book_id, int customer_id, int stuff_id,
            int price, string date_to, int count, string courier)
        {
            // Arrange
            var mock = new Mock<IOrderRepository>();
            var controller = new OrderController(_db, mock.Object);
            controller.ModelState.AddModelError("Name", "Required");
            OrderModel newOrder = new OrderModel()
            {
                BookId = book_id,
                CustomerId = customer_id,
                StuffId = stuff_id,
                Price = price,
                DateTo = date_to,
                Count = count,
                Courier = courier
            };
            
            // Act
            var result = controller.CreateOrder(newOrder);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(newOrder, viewResult?.Model);
        }
        
        private List<order> GetOrders()
        {
            MyBookShopContext db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var orders = new List<order>(db.Orders);
            return orders;
        }


        [Theory]
        [InlineData(3, 1, 1, 1, 400, "15.11.2018", 1, "Олег")]
        [InlineData(4, 4, 1, 1, 450, "26.11.2018", 2, "Владимир")]
        [InlineData(5, 1, 1, 2, 450, "30.11.2018", 3, "Петр")]
        public void Edit_Order_Redirects_And_EditOrder(int testOrderId, int book_id, int customer_id, int stuff_id,
            int price, string date_to, int count, string courier)
        {
            // Arrange
            var mock = new Mock<IOrderRepository>();
            mock.Setup(repo => repo.GetOrder(testOrderId))
                .Returns(GetOrders().FirstOrDefault(order => order.Id == testOrderId));
            var controller = new OrderController(_db, mock.Object);
            
            // Act
            var result = controller.EditOrder(testOrderId);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<EditOrderModel>(viewResult.ViewData.Model);
            Assert.Equal(book_id, model.BookId);
            Assert.Equal(customer_id, model.CustomerId);
            Assert.Equal(stuff_id, model.StuffId);
            Assert.Equal(price, model.Price);
            Assert.Equal(date_to, model.DateTo);
            Assert.Equal(count, model.Count);
            Assert.Equal(courier, model.Courier);
        }
    }
}