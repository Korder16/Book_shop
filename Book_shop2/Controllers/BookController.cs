using System.Linq;
using Book_shop2.Models;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Работник магазина")]
        public IActionResult Books()
        {
            return View(db.Books.ToList());
        }
        
        // Добавление книги
        [HttpGet]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult CreateBook()
        {
            ViewBag.Books = db.Books.ToList();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult CreateBook(book Book)
        {
            db.Books.Add(Book);
            db.SaveChanges();
            return View();
        }
    }
}