using Book_shop2.Models;
using Book_shop2.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Helpers.IRepositories
{
    public interface IOrderRepository : IRepository
    {
        void CreateOrder(order newOrder);
        void UpdateOrder(order currentOrder);
        order GetOrder(int id);
    }

    public class OrderRepository : IOrderRepository
    {
        private MyBookShopContext _db;

        public OrderRepository()
        {
            this._db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
        }
        
        public void CreateOrder(order newOrder)
        {
            _db.Orders.Add(newOrder);
        }

        public order GetOrder(int id)
        {
            return _db.Orders.Find(id);
        }

        
        public void UpdateOrder(order currentOrder)
        {
            _db.Entry(currentOrder).State = EntityState.Modified;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}