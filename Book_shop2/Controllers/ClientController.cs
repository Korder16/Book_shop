using System.Linq;
using Book_shop2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Book_shop2.Controllers
{
    public class ClientController : Controller
    {
        MyBookShopContext db;
        
        public ClientController(MyBookShopContext context)
        {
            db = context;
        }
        
        // Список покупателей
        [Authorize(Roles = "Работник магазина")]
        public IActionResult Clients()
        {
            return View(db.Clients.ToList());
        }
        
        // Добавление покупателя
        [HttpGet]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult AddClient(client Client)
        {
            db.Clients.Add(Client);
            db.SaveChanges();
            return View();
        }
    }
}