using System.Collections.Generic;

namespace Book_shop2.Models
{
    public class role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<user> Users { get; set; }

        public role()
        {
            Users = new List<user>();
        }
    }
}