namespace Book_shop2.Models
{
    public class purchase
    {
        public int id { get; set; }
        public int book_id { get; set; }
        public int price { get; set; }
        public int count { get; set; }
        public int cost { get; set; }
        public string year { get; set; }
        public int stuff_id { get; set; }
    }
}