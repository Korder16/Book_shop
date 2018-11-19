using System.ComponentModel.DataAnnotations;

namespace Book_shop2.Models
{
    public class supply
    {
        [Key]
        public int Supply_id { get; set; }
        public int Provider_id { get; set; }
        public int Book_id { get; set; }
        public int Count { get; set; }
        public string Date { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }
    }
}