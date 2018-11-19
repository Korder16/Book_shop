using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Book_shop2.Helpers;
using Remotion.Linq.Parsing.ExpressionVisitors.Transformation.PredefinedTransformations;

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
        public IActionResult Users()
        {
            ViewBag.User = db.Users.ToList();
            return View();
        }
    
        // Добавление пользователя
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
    
    
        [HttpPost]
        public IActionResult CreateUser(user User)
        {
            db.Users.Add(User);
            db.SaveChanges();
            return RedirectToAction("Users");
        }
    }
}