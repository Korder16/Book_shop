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
    public class PurchaseControllerTests
    {
        private MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());

        [Fact]
        public void Purhcases_Correct_View_Page()
        {
            // Arrange
            var mock = new Mock<IPurchaseRepository>();
            var controller = new PurchaseController(_db, mock.Object);
            
            // Act
            var result = controller.Purchases();
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }
        
        [Theory]
        [InlineData(1, 500, 2, 2)]
        [InlineData(7, 350, 5, 3)]
        public void Correct_Create_Purchase_And_Redirect(int book_id, int price, 
            int count, int stuff_id)
        {
            // Arrange
            var mock = new Mock<IPurchaseRepository>();
            var controller = new PurchaseController(_db, mock.Object);
            PurchaseModel newPurchase = new PurchaseModel()
            {
                Book_id = book_id,
                price = price,
                count = count,
                stuff_id = stuff_id,
            };
            
            // Act
            var result = controller.CreatePurchase(newPurchase);
            
            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Purchases", redirectResult?.ActionName);
        }
        
        
        [Theory]
        [InlineData(1, 500, -1, 2)]
        [InlineData(1, -5555, -1, 2)]
        [InlineData(7, -50, -5, 3)]
        [InlineData(3, -10, -5, 3)]
        public void DoNot_Create_Purchase_With_NoValid_Model(int book_id, int price, 
            int count, int stuff_id)
        {
            // Arrange
            var mock = new Mock<IPurchaseRepository>();
            var controller = new PurchaseController(_db, mock.Object);
            controller.ModelState.AddModelError("Name", "Required");
            PurchaseModel newPurchase = new PurchaseModel()
            {
                Book_id = book_id,
                price = price,
                count = count,
                stuff_id = stuff_id,
            };
            
            // Act
            var result = controller.CreatePurchase(newPurchase);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(newPurchase, viewResult?.Model);
        }
    }
}