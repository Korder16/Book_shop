using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Book_shop2.ViewModels
{
    public class SupplyModel
    {
        public int Provider_id { get; set; }
        public List<SelectListItem> Providers { get; set; }
        
        public int Book_id { get; set; }
        public List<SelectListItem> Books { get; set; }
        
        public string Date { get; set; }
        
        [Range(0, 100000)]
        [Required(ErrorMessage = "Не указана цена")]
        public int Price { get; set; }
        
        [Range(0, 100000)]
        [Required(ErrorMessage = "Не указано количество")]
        public int Count { get; set; }
        
        public int Cost { get; set; }
    }
}