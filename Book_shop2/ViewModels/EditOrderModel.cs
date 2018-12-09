using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Book_shop2.ViewModels
{
    public class EditOrderModel
    {
        public int Id { get; set; }
        
        public List<SelectListItem> Books { get; set; }
        
        public List<SelectListItem> Clients { get; set; }
        
        public List<SelectListItem> Users { get; set; }
        
        [Required(ErrorMessage = "Не указана книга")]
        public int BookId { get; set; }
        
        [Required(ErrorMessage = "Не указана покупатель")]
        public int CustomerId { get; set; }
        
        [Required(ErrorMessage = "Не указана продавец")]
        public int StuffId { get; set; }
        
        public string DateOn { get; set; }
        
        [Range(0, 100000)]
        [Required(ErrorMessage = "Не указана цена")]
        public int Price { get; set; }
        
        [Required(ErrorMessage = "Не указана дата доставки заказа")]
        public string DateTo { get; set; }
        
        [Range(0, 100000)]
        [Required(ErrorMessage = "Не указано количество")]
        public int Count { get; set; }
        
        public int Cost { get; set; }
        
        
        public string Status { get; set; }
        
        [Required(ErrorMessage = "Не указан курьер")]
        [RegularExpression(@"[a-zA-Z]{2,100}", ErrorMessage = "Некорректное имя курьера")]
        public string Courier { get; set; }
    }
}