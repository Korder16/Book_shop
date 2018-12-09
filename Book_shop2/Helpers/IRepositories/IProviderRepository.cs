using System.Collections.Generic;
using System.Linq;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Helpers.IRepositories
{
    public interface IProviderRepository : IRepository
    {
        IEnumerable<provider> GetAllProviders();
        void CreateProvider(provider newProvider);
    }

    public class ProviderRepository : IProviderRepository
    {
        private MyBookShopContext _db;

        public ProviderRepository()
        {
            this._db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
        }

        public void CreateProvider(provider newProvider)
        {
            _db.Providers.Add(newProvider);
        }

        public IEnumerable<provider> GetAllProviders()
        {
            return _db.Providers.ToList();
        }
        
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}