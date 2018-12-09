using System;
using System.Linq;
using Book_shop2.Models;
using Book_shop2.Helpers;
using Book_shop2.Helpers.IRepositories;
using Book_shop2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Book_shop2.Controllers
{
    public class PurchaseController : Controller
    {
        MyBookShopContext _db;
        private IPurchaseRepository _repo;
        
        public PurchaseController(MyBookShopContext context, IPurchaseRepository r)
        {
            _db = context;
            _repo = r;
        }
        
        // Список покупок
        [Authorize(Roles = "Работник магазина")]
        public IActionResult Purchases()
        {
            
            var purchase = from p in _db.Purchases
                join b in _db.Books on p.book_id equals b.id
                join u in _db.Users on p.stuff_id equals u.Id
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
            model.Books = _db.Books.Select(b => new SelectListItem
            {
                Text = b.name,
                Value = b.id.ToString()
            }).ToList();

            // Заполняем выпадающие список Users пользователями
            model.Users = _db.Users.Where(u => u.RoleId == 2).Select(u => new SelectListItem
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
            var currentBook = _db.Books.First(b => b.id == model.Book_id);
            
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
                    //_db.Purchases.Add(currentPurchase);
                    _repo.CreatePurchase(currentPurchase);

                    // Уменьшаем количество книг на складе
                    currentBook.count -= model.count;
                    _db.Entry(currentBook).State = EntityState.Modified;
                    
                    //_db.SaveChanges();
                    _repo.Save();
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
