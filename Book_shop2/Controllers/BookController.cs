using System.Linq;
using Book_shop2.Helpers.IRepositories;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace Book_shop2.Controllers
{
    public class BookController : Controller
    {
        private MyBookShopContext _db;
        private IBookRepository _repo;
        
        public BookController(MyBookShopContext context, IBookRepository r)
        {
            _db = context;
            _repo = r;
        }
        
        // Список книг
        [Authorize(Roles = "Работник магазина")]
        public IActionResult Books()
        {
            return View(_db.Books.ToList());
        }
        
        // Добавление книги
        [HttpGet]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult CreateBook()
        {
            //ViewBag.Books = _db.Books.ToList();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult CreateBook(book Book)
        {
            if (ModelState.IsValid)
            {
                _repo.CreateBook(Book);
                _repo.Save();
                return RedirectToAction("Books", "Book");
            }
            else
                ModelState.AddModelError("","Некорректные данные");

            return View(Book);
        }
    }
}