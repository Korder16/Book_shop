using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Book_shop2.Helpers;
using Remotion.Linq.Parsing.ExpressionVisitors.Transformation.PredefinedTransformations;

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
        
            
        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";

            return View();
        }

        // Статистика по работникам книжного магазина
        public IActionResult Statistics()
        {
            int countAllOrders = db.Orders.Count();
            var statStuff = from u in db.Users
                join o in db.Orders on u.Id equals o.Stuff_id
                join p in db.Purchases on u.Id equals p.stuff_id
                select new SqlRequestStatistics()
                {
                    Name = u.Name,
                    PurchasesCount = (from pp in db.Users select pp.Id).Count(),
                    OrdersCount = (from oo in db.Orders select oo.Id).Count(),
                    //OrdersCount = db.Orders.Count(),
                    OrdersPercent = (from oo in db.Orders select oo.Id).Count() / countAllOrders * 100
                    //OrdersPercent = db.Orders.Count() / countAllOrders * 100
                };
                
            ViewBag.StatOrdersStuff = statStuff;
            
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