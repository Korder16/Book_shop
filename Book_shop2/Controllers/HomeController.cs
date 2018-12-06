using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Book_shop2.Models;
using Book_shop2.Helpers;
using Microsoft.AspNetCore.Authorization;


namespace Book_shop2.Controllers
{
    public class HomeController : Controller
    {
        private MyBookShopContext db;
        
        public HomeController(MyBookShopContext context)
        {
            db = context;
        }
        
        // Статистика по работникам книжного магазина
        [Authorize(Roles = "Администратор")]
        public IActionResult Statistics()
        {
            ViewData["Message"] = "Hello!";


            double countAllOrders = db.Orders.Count();

            // Формируем статистику по продавцам
            var purchaseStatistics = db.Users.GroupJoin(
                db.Purchases,
                u => u.Id,
                p => p.stuff_id,
                (users, purchases) => new SqlRequestStatistics
                {
                    Name = users.Name,
                    PurchasesCount = db.Purchases.Count(pp => pp.stuff_id == users.Id),
                    OrdersCount = db.Orders.Count(o => o.Stuff_id == users.Id),
                    SuccessOrdersCount = db.Orders.Count(o => o.Stuff_id == users.Id && o.Status == "Доставлен"),
                    OrdersPercent = Math.Round(db.Orders
                                                   .Count(o => o.Stuff_id == users.Id
                                                               && o.Status == "Доставлен")
                                               / countAllOrders * 100.0)
                });

            ViewBag.stuffStatistics = purchaseStatistics;

            return View();
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