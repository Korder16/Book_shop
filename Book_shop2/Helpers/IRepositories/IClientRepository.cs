using System.Collections.Generic;
using System.Linq;
using Book_shop2.Helpers.IRepositories;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Helpers.IRepositories
{
    public interface IClientRepository : IRepository
    {
        IEnumerable<client> GetAllClients();
        client GetClient(int id);
        void CreateClient(client man);
        void UpdateClient(client man);
    }

    public class ClientRepository : IClientRepository
    {
        private MyBookShopContext _db;

        public ClientRepository()
        {
            this._db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
        }

        public IEnumerable<client> GetAllClients()
        {
            return _db.Clients.ToList();
        }

        public client GetClient(int id)
        {
            return _db.Clients.Find(id);
        }

        public void CreateClient(client man)
        {
            _db.Clients.Add(man);
        }

        public void UpdateClient(client man)
        {
            _db.Entry(man).State = EntityState.Modified;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}