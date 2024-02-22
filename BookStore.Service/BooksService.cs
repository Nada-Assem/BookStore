using BookStore.Core.Entities;
using BookStore.Core.Services.Contracts;
using BookStore.Repository;
using BookStore.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class BooksService : BooksRepository, IBookService
    {
        private readonly StoreContext _dbContext;

        public BooksService(StoreContext dbContext) : base(dbContext)
            => _dbContext = dbContext;


        public IEnumerable<Book> GetAllBooks()
        {
            return GetAll();
        }

        public Book GetBookById(int id)
        {

            return GetById(id);
        }

        public void AddBook(Book book)
        {
            Add(book);
        }

        public void UpdateBook(Book book)
        {
            Update(book);
        }

        public void DeleteBook(int id)
        {
            Delete(id);
        }
    }
}
