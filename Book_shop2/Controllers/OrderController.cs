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
    public class OrderController : Controller
    {
        private MyBookShopContext _db;
        private IOrderRepository _repo;
        
        public OrderController(MyBookShopContext context, IOrderRepository r)
        {
            _db = context;
            _repo = r;
        }
        
        // Список заказов
        [Authorize(Roles = "Работник магазина")]
        public IActionResult Orders()
        {
            var orders = from o in _db.Orders
                join b in _db.Books on o.Book_id equals b.id
                join c in _db.Clients on o.Customer_id equals c.Id
                select new SqlListOrders()
                {
                    Id = o.Id,
                    Name = b.name,
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
            model.Books = _db.Books.Select(b => new SelectListItem
            {
                Text = b.name,
                Value = b.id.ToString()
            }).ToList();

            
            // Заполняем выпадающий список Clients клиентами
            model.Clients = _db.Clients.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            }).ToList();
            
            
            // Заполняем выпадающие список Users пользователями
            model.Users = _db.Users.Where(u=> u.Activity == "Работает" && u.RoleId == 2)
                .Select(u => new SelectListItem
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
            var currentBook = _db.Books.First(b => b.id == model.BookId);
            
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                order currentOrder = new order()
                {
                    Book_id = model.BookId,
                    Customer_id = model.CustomerId,
                    Stuff_id = model.StuffId,
                    Date_on = now.ToString("d"),
                    Date_to = model.DateTo,
                    Count = model.Count,
                    Prise = model.Price,
                    Cost = model.Count * model.Price,
                    Status = "Не доставлен",
                    Courier_name = model.Courier
                };
                
                // Добавляем заказ
                //_db.Orders.Add(currentOrder);
                _repo.CreateOrder(currentOrder);
                
                // Уменьшаем количество книг на складе
                currentBook.count -= model.Count;
                _db.Entry(currentBook).State = EntityState.Modified;
                
                //_db.SaveChanges();
                _repo.Save();
                return RedirectToAction("Orders", "Order");
            }
            else
                ModelState.AddModelError("","Некорректные данные");
            
            
            return View(model);
        }
        
        // Редактирование информации о пользователе
        [HttpGet]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult EditOrder(int? id)
        {
            order currentOrder = _db.Orders.Find(id);
            
            if (currentOrder != null)
            {
                EditOrderModel model = new EditOrderModel
                {
                    Id = currentOrder.Id,
                    BookId = currentOrder.Book_id,
                    CustomerId = currentOrder.Customer_id,
                    StuffId = currentOrder.Stuff_id,
                    DateOn = currentOrder.Date_on,
                    DateTo = currentOrder.Date_to,
                    Price = currentOrder.Prise,
                    Count = currentOrder.Count,
                    Cost = currentOrder.Cost,
                    Status = currentOrder.Status,
                    Courier= currentOrder.Courier_name
                };
            
                // Заполняем выпадающий список Books книгами
                model.Books = _db.Books.Select(b => new SelectListItem
                {
                    Text = b.name,
                    Value = b.id.ToString()
                }).ToList();

            
                // Заполняем выпадающий список Clients клиентами
                model.Clients = _db.Clients.Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                }).ToList();
            
            
                // Заполняем выпадающие список Users пользователями
                model.Users = _db.Users.Where(u=> u.Activity == "Работает" && u.RoleId == 2)
                    .Select(u => new SelectListItem
                    {
                        Text = u.Name,
                        Value = u.Id.ToString()
                    }).ToList();
            
            
                return View(model);
            }

            return View();
        }
        
        [HttpPost]
        [Authorize(Roles = "Работник магазина")]
        public ActionResult EditOrder(EditOrderModel model)
        {
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                order currentOrder = new order
                {
                    Id = model.Id,
                    Book_id = model.BookId,
                    Customer_id = model.CustomerId,
                    Stuff_id = model.StuffId,
                    Date_on = model.DateOn,
                    Date_to = model.DateTo,
                    Count = model.Count,
                    Prise = model.Price,
                    Cost = model.Count * model.Price,
                    Status = model.Status,
                    Courier_name= model.Courier
                };
                
                // Обновляем информацию о заказе
                //_db.Entry(currentOrder).State = EntityState.Modified;
                //_db.SaveChanges();
                _repo.UpdateOrder(currentOrder);
                _repo.Save();
                return RedirectToAction("Orders", "Order");
            }
            else
                ModelState.AddModelError("","Некорректные данные");

            return View(model);
        }
    }
}