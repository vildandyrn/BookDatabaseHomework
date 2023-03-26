using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDatabaseHomework
{
    public class BookDeposit

    {
        private readonly BookDataContext _context;

        public BookDeposit(BookDataContext context)
        {
            _context = context;
        }

        public void InsertBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }
    }

}
