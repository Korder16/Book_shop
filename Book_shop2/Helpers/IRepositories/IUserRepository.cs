using Book_shop2.Models;

namespace Book_shop2.Helpers.IRepositories
{
    public interface IUserRepository : IRepository
    {
        user GetUser(int id);
        void CreateUser(user currentUser);
    }

    public class UserRepository : IUserRepository
    {
        private MyBookShopContext _db;
        
        public user GetUser(int id)
        {
            return _db.Users.Find(id);
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