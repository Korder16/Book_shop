using System.Linq;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_shop2.Controllers
{
    public class SupplyController : Controller
    {
        MyBookShopContext db;
        
        public SupplyController(MyBookShopContext context)
        {
            db = context;
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
    }
}