using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Models
{
    public class MyBookShopContext : DbContext
    {
        public DbSet<book> Books { get; set; }
        public DbSet<purchase> Purchases { get; set; }
        public DbSet<user> Users { get; set; }
        public DbSet<client> Clients { get; set; }
        public DbSet<order> Orders { get; set; }
        public DbSet<supply> Supplies { get; set; }
        public DbSet<provider> Providers { get; set; }
        public DbSet<role> Roles { get; set; }
        
        public MyBookShopContext(DbContextOptions<MyBookShopContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}