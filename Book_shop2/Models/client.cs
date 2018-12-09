using System.ComponentModel.DataAnnotations;

namespace Book_shop2.Models
{
    public class client
    {
        public int Id { get; set; }
        
        [RegularExpression(@"[a-zA-Z]{2,30}", ErrorMessage = "Некорректное имя")]
        [Required(ErrorMessage ="Не указано имя клиента")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Не указан номер телефона")]
        [RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", ErrorMessage = "Некорректный номер телефона")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Не указана почта")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Не указан номер телефона")]
        [RegularExpression(@"[a-zA-Z]{2,100}", ErrorMessage = "Некорректный адрес")]
        public string Adress { get; set; }
    }
}