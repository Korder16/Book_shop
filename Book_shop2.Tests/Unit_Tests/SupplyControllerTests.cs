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
    public class SupplyControllerTests
    {
        private MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());

        [Fact]
        public void Purhcases_Correct_View_Page()
        {
            // Arrange
            var mock = new Mock<ISupplyRepository>();
            var controller = new SupplyController(_db, mock.Object);
            
            // Act
            var result = controller.Supplies();
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }
        
        
        [Theory]
        [InlineData(1, 1, 300, 7)]
        [InlineData(3, 4, 250, 8)]
        [InlineData(3, 3, 200, 9)]
        public void Correct_Create_Supply_And_Redirect(int provider_id, int book_id, 
            int price, int count)
        {
            // Arrange
            var mock = new Mock<ISupplyRepository>();
            var controller = new SupplyController(_db, mock.Object);
            SupplyModel newSupply= new SupplyModel()
            {
                Provider_id= provider_id,
                Book_id = book_id,
                Price = price,
                Count = count
            };
            
            // Act
            var result = controller.AddSupply(newSupply);
            
            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Supplies", redirectResult?.ActionName);
        }
        
        
        [Theory]
        [InlineData(1, 1, 300, 7)]
        [InlineData(3, 4, 250, 8)]
        [InlineData(3, 3, 200, 9)]
        public void DoNot_Create_Supply_With_NoValid_Model(int provider_id, int book_id, 
            int price, int count)
        {
            // Arrange
            var mock = new Mock<ISupplyRepository>();
            var controller = new SupplyController(_db, mock.Object);
            controller.ModelState.AddModelError("Name", "Required");
            SupplyModel newSupply= new SupplyModel()
            {
                Provider_id= provider_id,
                Book_id = book_id,
                Price = price,
                Count = count
            };
            
            // Act
            var result = controller.AddSupply(newSupply);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(newSupply, viewResult?.Model);
        }
    }
}