using System.ComponentModel.DataAnnotations;

namespace Book_shop2.Models
{
    public class stock
    {
        [Key]
        public int Book_id { get; set; }
        public int Count { get; set; }
        public int Supply_id { get; set; }
    }
}