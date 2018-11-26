using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Book_shop2.Models
{
    public class user
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Activity { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public int? RoleId { get; set; }
        public role role { get; set; }
    }
}