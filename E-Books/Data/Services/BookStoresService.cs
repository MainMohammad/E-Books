using E_Books.Data.Base;
using E_Books.Models;

namespace E_Books.Data.Services
{
    public class BookStoresService : EntityBaseRepository<BookStore>, IBookStoresServices
    {
        public BookStoresService(AppDbContext context) : base(context) { }
    }
}
