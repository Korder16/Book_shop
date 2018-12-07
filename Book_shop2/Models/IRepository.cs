using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Models
{
    public interface IRepository : IDisposable
    {
        List<client> GetClientList();
        client GetClient(int id);
        void Create(client item);
        void Update(client item);
        void Save();
    }

    public class ClientRepository : IRepository
    {
        private MyBookShopContext db;

        public ClientRepository()
        {
            this.db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
        }

        public List<client> GetClientList()
        {
            return db.Clients.ToList();
        }

        public client GetClient(int id)
        {
            return db.Clients.Find(id);
        }

        public void Create(client item)
        {
            db.Clients.Add(item);
        }

        public void Update(client item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            db.SaveChanges();
        }
        
        private bool disposed = false;
        
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
  
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}