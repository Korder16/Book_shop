using System.Linq;
using Book_shop2.Helpers;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(order Order)
        {
            db.Orders.Add(Order);
            db.SaveChanges();
            return View();
        }
    }
}