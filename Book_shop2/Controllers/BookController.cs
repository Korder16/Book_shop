using System.Linq;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_shop2.Controllers
{
    public class BookController : Controller
    {
        MyBookShopContext db;
        
        public BookController(MyBookShopContext context)
        {
            db = context;
        }
        
        // Список книг
        public IActionResult Books()
        {
            return View(db.Books.ToList());
        }
        
        // Добавление книги
        [HttpGet]
        public IActionResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBook(book Book)
        {
            db.Books.Add(Book);
            db.SaveChanges();
            return View();
        }
    }
}