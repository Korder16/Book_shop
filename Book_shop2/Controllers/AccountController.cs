using System.Linq;
using Book_shop2.Models;
using Book_shop2.ViewModels;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Book_shop2.Helpers.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Book_shop2.Controllers
{
    public class AccountController : Controller
    {
        private MyBookShopContext _db;
        private IUserRepository _repo;

        public AccountController(MyBookShopContext context, IUserRepository r)
        {
            _db = context;
            _repo = r;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        // async Task<IActionResult>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //user user = await _db.Users
                user user = _db.Users
                    .Include(u => u.role)
                    .FirstOrDefault(u => u.Name == model.Name 
                                              && u.Password == model.Password && u.Activity == "Работает");
                
                if (user != null)
                {
                    //await Authenticate(user); // аутентификация
                    Authenticate(user); // аутентификация
                    var roleId = _db.Users.Where(u => u.Name.Contains(model.Name))
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
        public IActionResult Register(RegisterModel model)
        {
            if(ModelState.IsValid)
            {
                //user user = await _db.Users.FirstOrDefaultAsync(u => u.Name == model.Name);
                user currentUser = _db.Users.FirstOrDefault(u => u.Name == model.Name);
                if (currentUser == null)
                {
                    
                    // Добавляем пользователя в БД
                    currentUser = new user {Name = model.Name, Password = model.Password, 
                        Email = model.Email, Activity = model.Activity, RoleId = 2};
                    //var userRole = await _db.Roles.FirstOrDefaultAsync(r => r.Name == "Работник магазина");
                    var userRole = _db.Roles.FirstOrDefault(r => r.Name == "Работник магазина");
                    
                    if (userRole != null)
                        currentUser.role = userRole;

                    _db.Users.Add(currentUser);
                    //_repo.Save();
                    _db.SaveChanges();

                    return RedirectToAction("Users", "User");
                }
                else
                    ModelState.AddModelError("","Некорректные логин и(или) пароль");
            }
            else
            {
                ModelState.AddModelError("","Такой пользователь уже существует");
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