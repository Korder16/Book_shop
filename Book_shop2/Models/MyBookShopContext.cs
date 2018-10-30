using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Models
{
    public class MyBookShopContext : DbContext
    {
        public MyBookShopContext(DbContextOptions<MyBookShopContext> options) : base(options) { }
        
        public DbSet<book> Books { get; set; }
        public DbSet<purchase> Purchase { get; set; }
    }
}