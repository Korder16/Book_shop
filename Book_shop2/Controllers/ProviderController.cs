using System.Linq;
using Book_shop2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Book_shop2.Controllers
{
    public class ProviderController : Controller
    {
        MyBookShopContext db;
        
        public ProviderController(MyBookShopContext context)
        {
            db = context;
        }
        
        // Список поставщиков
        [Authorize(Roles = "Администратор")]
        public IActionResult Providers()
        {
            return View(db.Providers.ToList());
        }
        
        // Добавление поставщика
        [HttpGet]
        [Authorize(Roles = "Администратор")]
        public IActionResult CreateProvider()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Администратор")]
        public IActionResult CreateProvider(provider Provider)
        {
            if (ModelState.IsValid)
            {
                db.Providers.Add(Provider);
                db.SaveChanges();
                return RedirectToAction("Providers", "Provider");
            } 
            else
                ModelState.AddModelError("","Некорректные даные");
            
            return View(Provider);
        }
    }
}