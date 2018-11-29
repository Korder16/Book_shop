using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Book_shop2.ViewModels
{
    public class PurchaseModel
    {

        [Required(ErrorMessage ="Не указана книга")]
        //public SelectList book_id { get; set; }
        public int Book_id { get; set; }
        
        [Range(0, 100000)]
        [Required(ErrorMessage = "Не указана цена")]
        public int price { get; set; }
         
        [Range(0, 100000)]
        [Required(ErrorMessage = "Не указано количество")]
        public int count { get; set; }
        
        
        public int cost { get; set; }
        
        
        public string year { get; set; }
        
        [Required(ErrorMessage = "Не указан продавец")]
        public int stuff_id { get; set; }

        public List<SelectListItem> Books { get; set; }
        
        public List<SelectListItem> Users { get; set; }
    }
}
