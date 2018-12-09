using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Helpers.IRepositories
{
    public interface ISupplyRepository : IRepository
    {
        void CreateSupply(supply newSupply);
    }

    public class SupplyRepository : ISupplyRepository
    {
        private readonly MyBookShopContext _db;

        public SupplyRepository()
        {
            this._db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
        }
        
        public void CreateSupply(supply newSupply)
        {
            _db.Supplies.Add(newSupply);
        }
        
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}