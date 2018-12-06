using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Book_shop2.ViewModels;
using Book_shop2.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

//using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;

namespace Book_shop2.Controllers
{
    public class AccountController : Controller
    {
        private MyBookShopContext db;

        public AccountController(MyBookShopContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                user user = await db.Users
                    .Include(u => u.role)
                    .FirstOrDefaultAsync(u => u.Name == model.Name 
                                              && u.Password == model.Password && u.Activity == "Работает");
                
                if (user != null)
                {
                    await Authenticate(user); // аутентификация
                    var roleId = db.Users.Where(u => u.Name.Contains(model.Name))
                        .Select(u=>u.RoleId).First();
                    
                    // Редирект на начальную страницу пользователя
                    switch (roleId)
                    {
                        // Пользователь - администратор
                        case 1:
                            return RedirectToAction("Statistics", "Home");
                        
                        // Пользователь - работник магазина
                        case 2:
                            return RedirectToAction("Books", "Book");
                        
                        default:
                            return View(model);
                    }
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);   
        }

        // Регистрация нового пользователя
        [HttpGet]
        [Authorize(Roles = "Администратор")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Администратор")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if(ModelState.IsValid)
            {
                user user = await db.Users.FirstOrDefaultAsync(u => u.Name == model.Name);
                if (user == null)
                {
                    
                    // Добавляем пользователя в БД
                    
                    user = new user {Name = model.Name, Password = model.Password, 
                        Email = model.Email, Activity = model.Activity, RoleId = 2};
                    var userRole = await db.Roles.FirstOrDefaultAsync(r => r.Name == "Работник магазина");
               
                    if (userRole != null)
                        user.role = userRole;

                    db.Users.Add(user);
                    await db.SaveChangesAsync();

                    return RedirectToAction("Users", "User");
                }
                else
                    ModelState.AddModelError("","Некорректные логин и(или) пароль");
            }

            return View(model);
        }

        public async Task Authenticate(user user)
        {
            // Создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.role?.Name)
            };
            
            //Создаем объект ClaimIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", 
                                    ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            
            // Устновка аутентифицированных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}