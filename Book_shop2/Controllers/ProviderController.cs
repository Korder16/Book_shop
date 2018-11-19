using System.Linq;
using Book_shop2.Models;
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
    }
}