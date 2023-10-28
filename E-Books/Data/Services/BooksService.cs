using E_Books.Data.Base;
using E_Books.Data.ViewModels;
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

        public async Task AddNewBook(NewBookVM data)
        {
            var newBook = new Book() 
            {
                Title = data.Title,
                PublishDate = data.PublishDate,
                Price = data.Price,
                Summary = data.Summary,
                BookCover = data.BookCover,
                Genre = data.Genre,
                PublisherId = data.PublisherId
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            foreach(var authorId in data.AuthorIds)
            {
                var newAuthorBook = new Author_Book()
                {
                    BookId = newBook.Id,
                    AuthorId = authorId
                };
                await _context.Authors_Books.AddAsync(newAuthorBook);
            }
            await _context.SaveChangesAsync();

            foreach(var bookstoreId in data.BookStoreIds)
            {
                var newBookStoresBook = new BookStore_Book()
                {
                    BookStoreId = bookstoreId,
                    BookId = newBook.Id
                };
                await _context.BookStores_Books.AddAsync(newBookStoresBook);
            }
            await _context.SaveChangesAsync();
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

        public async Task<NewBookDropdownsVM> GetNewBookDropdownVals()
        {
            var response = new NewBookDropdownsVM()
            {
                Authors = await _context.Authors.OrderBy(a => a.Name).ToListAsync(),
                Publishers = await _context.Publishers.OrderBy(p => p.Name).ToListAsync(),
                BookStores = await _context.BookStores.OrderBy(bs => bs.Name).ToListAsync()
            }; 
            
            return response;
        }
}
}
