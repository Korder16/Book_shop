using System.Collections.Generic;
using System.Linq;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Helpers.IRepositories
{
    public interface IUserRepository : IRepository
    {
        IEnumerable<user> GetAllUsers();
        user GetUser(int id);
        void UpdateUser(user currentUser);
        void CreateUser(user currentUser);
    }

    public class UserRepository : IUserRepository
    {
        private MyBookShopContext _db;
        
        public user GetUser(int id)
        {
            return _db.Users.Find(id);
        }

        public IEnumerable<user> GetAllUsers()
        {
            return _db.Users.ToList();
        }
        
        public void UpdateUser(user currentUser)
        {
            _db.Entry(currentUser).State = EntityState.Modified;
        }

        public void CreateUser(user currentUser)
        {
            _db.Users.Add(currentUser);
        }
        
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}