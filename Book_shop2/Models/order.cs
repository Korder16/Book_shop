namespace Book_shop2.Models
{
    public class order
    {
        public int Id { get; set; }
        public int Book_id { get; set; }
        public int Customer_id { get; set; }
        public int Stuff_id { get; set; }
        public string Date_on { get; set; }
        public string Date_to { get; set; }
        public int Count { get; set; }
        public int Prise { get; set; }
        public int Cost { get; set; }
        public string Status { get; set; }
        public string Courier_name { get; set; }
    }
}