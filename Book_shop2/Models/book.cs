using System.ComponentModel.DataAnnotations;

namespace Book_shop2.Models
{
    public class book
    {
        public int id { get; set; }
        
        [RegularExpression(@"[a-zA-Z]{2,100}", ErrorMessage = "Некорректное название книги")]
        [Required(ErrorMessage ="Не указано название книги")]
        public string name { get; set; }
        
        [RegularExpression(@"[a-zA-Z]{2,100}", ErrorMessage = "Некорректное имя автора")]
        [Required(ErrorMessage ="Не указано имя автора")]
        public string author { get; set; }
        
        [Range(0, 100000)]
        [Required(ErrorMessage ="Не указана цена")]
        public int price { get; set; }
        
        [RegularExpression(@"[a-zA-Z]{2,100}", ErrorMessage = "Некорректное название жанра")]
        [Required(ErrorMessage ="Не указан жанр книги")]
        public string genre { get; set; }
        
        [Range(0, 2018)]
        [Required(ErrorMessage ="Не указан год издания")]
        public int year { get; set; }
        
        [Range(0, 10000)]
        [Required(ErrorMessage = "Не указано количество")]
        public int count { get; set; }
    }
}