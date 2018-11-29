using System;
using System.Linq;
using Book_shop2.Helpers;
using Book_shop2.Models;
using Book_shop2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
        [Authorize(Roles = "Работник магазина")]
        public IActionResult Supplies()
        {

            var supplies = from s in db.Supplies
                join p in db.Providers on s.Provider_id equals p.Id
                join b in db.Books on s.Book_id equals b.id
                select new SqlRequestSupplies
                {
                    ProviderName = p.Name,
                    BookName = b.name,
                    Date = s.Date,
                    Price = s.Price,
                    Count = s.Count,
                    Cost = s.Cost
                };

            ViewBag.Supplies = supplies;
            return View();
        }
        
        // Добавление поставки
        [HttpGet]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult AddSupply()
        {
            SupplyModel model = new SupplyModel();
            
            // Заполняем выпадающий список Books книгами
            model.Books = db.Books.Select(b => new SelectListItem
            {
                Text = b.name,
                Value = b.id.ToString()
            }).ToList();

            // Заполняем выпадающий список Providers поставщиками
            model.Providers = db.Providers.Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString()
            }).ToList();
            
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult AddSupply(SupplyModel model)
        {
            var currentBook = db.Books.First(b => b.id == model.Book_id);
            
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                supply currentSupply = new supply()
                {
                    Provider_id = model.Provider_id,
                    Book_id = model.Book_id,
                    Count = model.Count,
                    Date = now.ToString("d"),
                    Price = model.Price,
                    Cost = model.Count * model.Price
                };
                
                db.Supplies.Add(currentSupply);
                
                // Увеличиваем количество книг на складе
                currentBook.count += model.Count;
                db.Entry(currentBook).State = EntityState.Modified;
                
                db.SaveChanges();
                
                return RedirectToAction("Supplies", "Supply");
            }
            else
                ModelState.AddModelError("","Некорректные данные");

            return View(model);
        }
    }
}