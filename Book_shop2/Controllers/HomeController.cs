using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Book_shop2.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Rewrite.Internal.PatternSegments;
using Newtonsoft.Json;
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
        
        
        [Authorize]
        public IActionResult Index()
        {
            return View(db.Books.ToList());
        }


        // Статистика по работникам книжного магазина
        [Authorize(Roles = "Администратор")]
        public IActionResult Statistics()
        {
            int countAllOrders = db.Orders.Count();

            var stuffStatistics = db.Users.GroupJoin(db.Purchases,
                u => u.Id,
                p => p.stuff_id,
                (u, p) => new SqlRequestStatistics()
                {
                    Name = u.Name,
                    PurchasesCount = db.Purchases.Count(purchase => purchase.stuff_id == u.Id),
                    OrdersCount = db.Orders.Count(order => order.Stuff_id == u.Id)
                });
            
            
            ViewBag.StatOrdersStuff = stuffStatistics;

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