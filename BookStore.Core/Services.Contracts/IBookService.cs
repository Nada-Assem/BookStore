using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookStore.Core.Services.Contracts
{
    public interface IBookService
    {     
            IEnumerable<Book> GetAllBooks();
            Book GetBookById(int id);
            void AddBook(Book book);
            void UpdateBook(Book book);
            void DeleteBook(int id);
            Book GetBookByName(string name);
        public List<Book> GetBooksByCategoryId(int categoryId);

    }
}
