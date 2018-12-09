using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Helpers.IRepositories
{
    public interface IPurchaseRepository : IRepository
    {
        void CreatePurchase(purchase newPurchase);
    }

    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly MyBookShopContext _db;

        public PurchaseRepository()
        {
            this._db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
        }

        public void CreatePurchase(purchase newPurchase)
        {
            _db.Purchases.Add(newPurchase);
        }
        
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}