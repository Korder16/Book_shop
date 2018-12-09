using System.ComponentModel.DataAnnotations;

namespace Book_shop2.ViewModels
{
    public class LoginModel
    {
        [RegularExpression(@"[a-zA-Z]{2,100}", ErrorMessage = "Некорректное имя пользователя")]
        [Required(ErrorMessage = "Не указано имя пользователя")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}