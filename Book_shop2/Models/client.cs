using System.ComponentModel.DataAnnotations;

namespace Book_shop2.Models
{
    public class client
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Не указано имя клиента")]
        public string Name { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="Не указан номер телефона")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Не указана почта")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Не указан номер телефона")]
        public string Adress { get; set; }
    }
}