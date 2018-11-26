using System;
using System.Linq;
using Book_shop2.Helpers;
using Book_shop2.Models;
using Book_shop2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Book_shop2.Controllers
{
    public class OrderController : Controller
    {
        MyBookShopContext db;
        
        public OrderController(MyBookShopContext context)
        {
            db = context;
        }
        
        // Список заказов
        [Authorize(Roles = "Работник магазина")]
        public IActionResult Orders()
        {
            var orders = from o in db.Orders
                join b in db.Books on o.Book_id equals b.id
                join c in db.Clients on o.Customer_id equals c.Id
                select new SqlListOrders()
                {
                    Name = b.name,
                    Genre = b.genre,
                    Author = b.author,
                    Client = c.Name,
                    Phone = c.Phone,
                    Adress = c.Adress,
                    Date_on = o.Date_on,
                    Date_to = o.Date_to,
                    Price = o.Prise,
                    Count = o.Count,
                    Cost = o.Cost,
                    Status = o.Status,
                    Courier_name = o.Courier_name
                };
            
            ViewBag.ListOrders = orders;
            return View();
        }
        
        // Добавление заказа
        [HttpGet]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult CreateOrder()
        {
            OrderModel model = new OrderModel();
            
            // Заполняем выпадающий список Books книгами
            model.Books = db.Books.Select(b => new SelectListItem
            {
                Text = b.name,
                Value = b.id.ToString()
            }).ToList();

            
            // Заполняем выпадающий список Clients клиентами
            model.Clients = db.Clients.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            }).ToList();
            
            
            // Заполняем выпадающие список Users пользователями
            model.Users = db.Users.Where(u=> u.Activity == "Работает" && u.RoleId == 2).Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            }).ToList();
            
            
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult CreateOrder(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                order currentOrder = new order()
                {
                    Book_id = model.BookId,
                    Customer_id = model.CustomerId,
                    Stuff_id = model.CustomerId,
                    Date_on = now.ToString("d"),
                    Date_to = model.DateTo,
                    Count = model.Count,
                    Prise = model.Price,
                    Cost = model.Count * model.Price,
                    Status = "Не доставлен",
                    Courier_name = model.Courier
                };
                
                
                db.Orders.Add(currentOrder);
                db.SaveChanges();
                return RedirectToAction("Orders", "Order");
            }
            else
                ModelState.AddModelError("","Некорректные данные");
            
            
            return View(model);
        }
    }
}