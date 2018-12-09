using System.ComponentModel.DataAnnotations;


namespace Book_shop2.ViewModels
{
    public class RegisterModel
    {
        
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Не указано имя пользователя")]
        [RegularExpression(@"[a-zA-Z]{3,50}", ErrorMessage = "Некорректное имя пользователя")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Name { get; set; }
         
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }
         
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
        
        [Required(ErrorMessage = "Не указана почта")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Не указан статус")]
        public string Activity { get; set; }
        
        public string RoleId { get; set; }
    }
}