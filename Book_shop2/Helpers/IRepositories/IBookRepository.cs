using System.Collections.Generic;
using System.Linq;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Helpers.IRepositories
{
    public interface IBookRepository : IRepository
    {
        IEnumerable<book> GetAllBooks();
        void CreateBook(book currentBook);
    }
    
    public class BookRepository : IBookRepository
    {
        private MyBookShopContext _db;

        public BookRepository()
        {
            this._db = new MyBookShopContext(new DbContextOptions<MyBookShopContext>());
        }

        public IEnumerable<book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public void CreateBook(book currentBook)
        {
            _db.Books.Add(currentBook);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}