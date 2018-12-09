using System.Collections.Generic;
using System.Linq;
using Book_shop2.Helpers.IRepositories;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Controllers
{
    public class ProviderController : Controller
    {
        private MyBookShopContext _db;
        private IProviderRepository _repo;
        
        public ProviderController(MyBookShopContext context, IProviderRepository r)
        {
            _db = context;
            _repo = r;
        }
        
        // Список поставщиков
        [Authorize(Roles = "Администратор")]
        public IActionResult Providers()
        {
            return View(_db.Providers.ToList());
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
                //_db.Providers.Add(Provider);
                //_db.SaveChanges();
                _repo.CreateProvider(Provider);
                _repo.Save();
                return RedirectToAction("Providers", "Provider");
            } 
            else
                ModelState.AddModelError("","Некорректные даные");
            
            return View(Provider);
        }
    }
}