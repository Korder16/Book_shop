using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Book_shop2.Models;
using Book_shop2.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Book_shop2.Controllers
{
    public class UserController : Controller
    {
        MyBookShopContext db;

        public UserController(MyBookShopContext context)
        {
            db = context;
        }
    
        // Список пользователей
        [Authorize(Roles = "Администратор")]
        public IActionResult Users()
        {
            return View(db.Users.ToList());
        }
        
        // Редактирование информации о пользователе
        [HttpGet]
        [Authorize(Roles = "Администратор")]
        public IActionResult EditUser(int? id)
        {
            user currentUser = db.Users.Find(id);
            
            if (currentUser != null)
            {
                EditUserModel model = new EditUserModel();
                model.Id = currentUser.Id;
                model.Name = currentUser.Name;
                model.Email = currentUser.Email;
                model.Password = currentUser.Password;
                model.Activity = currentUser.Activity;
                model.RoleId = currentUser.RoleId;
            
                // Заполянем список должностей
                model.Roles = db.Roles.Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Id.ToString()
                }).ToList();
            
            
                return View(model);
            }

            return View();
        }
        
        [HttpPost]
        [Authorize(Roles = "Администратор")]
        public ActionResult EditUser(EditUserModel model)
        {
            if (ModelState.IsValid)
            {
                user currentUser = new user();
                
                currentUser.Id = model.Id;
                currentUser.Name = model.Name;
                currentUser.Email = model.Email;
                currentUser.Password = model.Password;
                currentUser.Activity = model.Activity;
                currentUser.RoleId = model.RoleId;
                
                
                db.Entry(currentUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Users", "User");
            }
            else
                ModelState.AddModelError("","Некорректные данные");

            return View();
        }
    }
}