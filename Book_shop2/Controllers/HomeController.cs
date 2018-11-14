using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;

namespace Book_shop2.Controllers
{
    public class HomeController : Controller
    {
        MyBookShopContext db;
        
        public HomeController(MyBookShopContext context)
        {
            db = context;
        }
        
        public IActionResult Index()
        {
            return View(db.Books.ToList());
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

        // Список пользователей
        public IActionResult Users()
        {
            return View(db.Users.ToList());
        }

        // Добавление пользователя
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult CreateUser(user User)
        {
            db.Users.Add(User);
            db.SaveChanges();
            return RedirectToAction("Users");
        }
        
        // Список покупателей
        public IActionResult Clients()
        {
            return View(db.Clients.ToList());
        }
        
        // Добавление покупателя
        [HttpGet]
        public IActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddClient(client Client)
        {
            db.Clients.Add(Client);
            db.SaveChanges();
            return View();
        }
        
        // Список покупок
        public IActionResult Purchases()
        {
            //var book_name = db.Query<db>("select b.name from db.book b, db.purchase p where b.id == p.book_id").ToList();
            return View(db.Purchases.ToList());
        }
        
        // Оформление покупки
        [HttpGet]
        public IActionResult CreatePurchase()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePurchase(purchase Purchase)
        {
            db.Purchases.Add(Purchase);
            db.SaveChanges();
            return View();
        }
        
        // Список заказов
        public IActionResult Orders()
        {
            var books = "select b.name from db.Books b, db.Orders o where b.id == o.book_id";
            //var row = db.QuerySingle(books);
            return View(db.Orders.ToList());
        }
        
        // Добавление заказа
        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(order Order)
        {
            db.Orders.Add(Order);
            db.SaveChanges();
            return View();
        }
        
        // Список поставщиков
        public IActionResult Providers()
        {
            return View(db.Providers.ToList());
        }
        
        // Добавление поставщика
        [HttpGet]
        public IActionResult CreateProvider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProvider(provider Provider)
        {
            db.Providers.Add(Provider);
            db.SaveChanges();
            return View();
        }
        
        // Список поставок
        public IActionResult Supplies()
        {
            return View(db.Supplies.ToList());
        }
        
        // Добавление поставки
        [HttpGet]
        public IActionResult AddSupply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSupply(supply Supply)
        {
            db.Supplies.Add(Supply);
            db.SaveChanges();
            return View();
        }
            
        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(db.Users.ToList());
        }

        [HttpPost]
        public IActionResult Login(string login, string password, int age, string comment)
        {
            string authData = $"Login: {login}   Password: {password}   Age: {age}  Comment: {comment}";
            return Content(authData);
        }
        
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}