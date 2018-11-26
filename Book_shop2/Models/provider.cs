using System.ComponentModel.DataAnnotations;

namespace Book_shop2.Models
{
    public class provider
    {
        public int Id { get; set; }
        
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Не указано название")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Name { get; set; }
        
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Не указан город")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Не указан телефон")]
        [RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", ErrorMessage = "Некорректный телефон")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Не указана почта")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
    }
}