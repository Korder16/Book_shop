using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Book_shop2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Book_shop2.ViewModels
{
    public class EditUserModel
    {
        public int Id { get; set; }
        
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Не указано имя пользователя")]
        [RegularExpression(@"[а-яА-Я\s]{2,100}", ErrorMessage = "Некорректное имя пользователя")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Name { get; set; }
        
        public string Activity { get; set; }
        
        [Required(ErrorMessage = "Не указана почта")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }
        
        public List<SelectListItem> Roles { get; set; }
        
        public int? RoleId { get; set; }
        public role role { get; set; }
    }
}