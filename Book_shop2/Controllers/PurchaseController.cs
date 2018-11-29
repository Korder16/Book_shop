using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using Book_shop2.Helpers;
using Book_shop2.Models;
using Book_shop2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
        [Authorize(Roles = "Работник магазина")]
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
        [Authorize(Roles = "Работник магазина")]
        public IActionResult CreatePurchase()
        {
            PurchaseModel model = new PurchaseModel();
            
            // Заполняем выпадающий список Books книгами
            model.Books = db.Books.Select(b => new SelectListItem
            {
                Text = b.name,
                Value = b.id.ToString()
            }).ToList();

            // Заполняем выпадающие список Users пользователями
            model.Users = db.Users.Where(u => u.RoleId == 2).Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            }).ToList();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult CreatePurchase(PurchaseModel model)
        {
            var currentBook = db.Books.First(b => b.id == model.Book_id);
            
            if (model.count <= currentBook.count)
            {
                if (ModelState.IsValid)
                {
                    DateTime now = DateTime.Now;
                
                    purchase currentPurchase = new purchase()
                    {
                        book_id = model.Book_id,
                        price =  model.price,
                        count = model.count,
                        cost = model.price * model.count,
                        stuff_id = model.stuff_id,
                        year = now.ToString("d")
                    };
                    
                    // Добавление новой покупки
                    db.Purchases.Add(currentPurchase);

                    // Уменьшаем количество книг на складе
                    currentBook.count -= model.count;
                    db.Entry(currentBook).State = EntityState.Modified;
                    
                    db.SaveChanges();
                    return RedirectToAction("Purchases", "Purchase");
                }
                else
                    ModelState.AddModelError("","Некорректные данные");
            }
            else
                ModelState.AddModelError("","Количество книг на складе:" + model.count);
            
            return View(model);
        }
    }
}
