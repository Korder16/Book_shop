using System.Linq;
using Book_shop2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            return RedirectToAction("Clients", "Client");
        }
        
        
        // Редактирование информации о клиенте
        [HttpGet]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult EditClient(int? id)
        {
            client currentClient = db.Clients.Find(id);

            if (currentClient != null)
            {
                client model = new client
                {
                    Id = currentClient.Id,
                    Adress = currentClient.Adress,
                    Email = currentClient.Email,
                    Name = currentClient.Name,
                    Phone = currentClient.Phone
                };

                return View(model);
            }

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Работник магазина")]
        public IActionResult EditClient(client model)
        {
            if (ModelState.IsValid)
            {
                client currentClient = new client
                {
                    Id = model.Id,
                    Adress = model.Adress,
                    Email = model.Email,
                    Name = model.Name,
                    Phone = model.Phone
                };
                
                // Обновляем информацию о клиенте
                db.Entry(currentClient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Clients", "Client");
            }
            else
                ModelState.AddModelError("","Некорректные данные");

            return View();
        }
    }
}