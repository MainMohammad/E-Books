using E_Books.Data.Base;
using E_Books.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace E_Books.Data.Services
{
    public class BooksService : EntityBaseRepository<Book>, IBooksServices
    {
        private readonly AppDbContext _context;
        public BooksService(AppDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<Book> GetBookById(int id)
        {
            var bookDetails = _context.Books
                .Include(p => p.Publisher)
                .Include(ab => ab.Authors_Books).ThenInclude(a => a.Author)
                .Include(bb => bb.BookStores_Books).ThenInclude(bs => bs.BookStore)
                .FirstOrDefaultAsync(b => b.Id == id);

            return await bookDetails;
        }
    }
}
