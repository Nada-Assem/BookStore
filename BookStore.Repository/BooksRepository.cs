﻿using BookStore.Core.Entities;
using BookStore.Core.Repositories.Contracts;
using BookStore.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BooksRepository:IBookRepository
    {
        private readonly StoreContext _context;

        public BooksRepository(StoreContext dbContext)
        {
            _context = dbContext;
        }
        public IEnumerable<Book> GetAll()
        {
            return _context.Books.Include(b => b.BookAuthors)
                                  .Include(b => b.BookPublishers)
                                  .Include(b => b.BookOrders)
                                  .Include(b => b.BookCustomers);
                                  
        }
        public List<Book> GetBooksByCategoryId(int categoryId)
        {
          
              
                var books = _context.Books
                    .Where(b => b.CategoryId== categoryId)
                    .ToList();

                return books;
            
        }

        public Book GetByName(string name )
        {
            return _context.Books.Include(b => b.BookAuthors)
                                .Include(b => b.BookPublishers)
                                .Include(b => b.BookOrders)
                                .Include(b => b.BookCustomers)
                                .FirstOrDefault(b => b.Title == name);
        }
        public Book GetById(int id)
        {
            return _context.Books.Include(b => b.BookAuthors)
                                  .Include(b => b.BookPublishers)
                                  .Include(b => b.BookOrders)
                                  .Include(b => b.BookCustomers)
                                  .FirstOrDefault(b => b.Id == id);
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var bookToDelete = _context.Books.Find(id);
            if (bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }
        }
    }
}
