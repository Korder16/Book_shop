using System.Collections.Generic;
using System.Linq;
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
    public class BookControllerTests
    {
        private MyBookShopContext _db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
        
        [Fact]
        public void Books_Correct_View_Page()
        {
            // Arrange
            var mock = new Mock<IBookRepository>();
            mock.Setup(repo => repo.GetAllBooks()).Returns(GetBooks());
            var controller = new BookController(_db, mock.Object);
            
            // Act
            var result = controller.Books();
            
            // Assert
            // Является ли возвращаемый результат объектом ViewResult
            var viewResult = Assert.IsType<ViewResult>(result);
            
            // Передается ли в преставление IEnumrable<book>
            var model = Assert.IsAssignableFrom<IEnumerable<book>>(viewResult.Model);
            
            // Сравнивается количество обхектов, которые передаются в представление
            Assert.Equal(GetBooks().Count, model.Count());
        }
        
        private List<book> GetBooks()
        {
            MyBookShopContext db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
            var books = new List<book>(db.Books);
            return books;
        }


        // Проверяем функцию добавления книги на правильность работы
        [Theory]
        [InlineData("1984", "Джордж Оруэлл", "Роман", 350, 1949, 0)]
        [InlineData("Маленький принц", "Антуан де Сент-Экзюпери", "Сказка", 250, 1942, 0)]
        public void Correct_Create_Book_And_Redirect(string name, string author, string genre, 
            int price, int year, int count)
        {
            // Arrange
            var mock = new Mock<IBookRepository>();
            var controller = new BookController(_db, mock.Object);
            book newBook = new book()
            {
                name = name,
                author = author,
                genre = genre,
                price = price,
                year = year,
                count = count
            };
            
            // Act
            var result = controller.CreateBook(newBook);
            
            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Books", redirectResult?.ActionName);
        }
        
        
        [Theory]
        [InlineData("1984", "", "Роман", 350, 1949, 0)]
        [InlineData("Маленький принц", "Антуан де Сент-Экзюпери", "", 250, 1942, 0)]
        [InlineData("", "", "", 250, 0, 0)]
        [InlineData("", "", "", 250, -1, -1)]
        public void DoNot_Create_Book_With_NoValid_Model(string name, string author, string genre, 
            int price, int year, int count)
        {
            // Arrange
            var mock = new Mock<IBookRepository>();
            var controller = new BookController(_db, mock.Object);
            controller.ModelState.AddModelError("Name", "Required");
            book newBook = new book()
            {
                name = name,
                author = author,
                genre = genre,
                price = price,
                year = year,
                count = count
            };
            
            // Act
            var result = controller.CreateBook(newBook);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(newBook, viewResult?.Model);
        }
    }
}