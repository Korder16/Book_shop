using System;
using System.Linq;
using Book_shop2.Models;
using Book_shop2.Helpers;
using System.Diagnostics;
using Book_shop2.Helpers.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace Book_shop2.Controllers
{
    public class HomeController : Controller
    {
        private MyBookShopContext _db;
        private IHomeRepository _repo;
        
        public HomeController(MyBookShopContext context, IHomeRepository r)
        {
            _db = context;
            _repo = r;
        }
        
        // Статистика по работникам книжного магазина
        [Authorize(Roles = "Администратор")]
        public IActionResult Statistics()
        {

            double countAllOrders = _db.Orders.Count();

            // Формируем статистику по продавцам
            var purchaseStatistics = _db.Users.GroupJoin(
                _db.Purchases,
                u => u.Id,
                p => p.stuff_id,
                (users, purchases) => new SqlRequestStatistics
                {
                    Name = users.Name,
                    PurchasesCount = _db.Purchases.Count(pp => pp.stuff_id == users.Id),
                    OrdersCount = _db.Orders.Count(o => o.Stuff_id == users.Id),
                    SuccessOrdersCount = _db.Orders.Count(o => o.Stuff_id == users.Id && o.Status == "Доставлен"),
                    OrdersPercent = Math.Round(_db.Orders
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