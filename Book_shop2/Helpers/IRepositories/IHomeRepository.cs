using System;
using System.Collections.Generic;
using System.Linq;
using Book_shop2.Models;

namespace Book_shop2.Helpers.IRepositories
{
    public interface IHomeRepository : IRepository {}

    public class HomeRepository : IHomeRepository
    {
        private MyBookShopContext _db;
        
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}