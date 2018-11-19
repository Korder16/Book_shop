using System.Linq;
using Book_shop2.Helpers;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_shop2.Controllers
{
    public class PurchaseController : Controller
    {
        MyBookShopContext db;
        
        public PurchaseController(MyBookShopContext context)
        {
            db = context;
        }
        
        // Список покупок
        public IActionResult Purchases()
        {
            
            var purchase = from p in db.Purchases
                join b in db.Books on p.book_id equals b.id
                join u in db.Users on p.stuff_id equals u.Id
                select new SqlListPurchases()
                {
                    Name = b.name,
                    Author = b.author,
                    Price = p.price,
                    Count = p.count,
                    Cost = p.cost,
                    User = u.Name,
                    Date = p.year
                };
            
            ViewBag.ListPurchases = purchase;
            
            return View();
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
    }
}