using E_Books.Data.Base;
using E_Books.Models;

namespace E_Books.Data.Services
{
    public class AuthorsService : EntityBaseRepository<Author>, IAuthorsServices
    {
        public AuthorsService(AppDbContext context) : base(context) { }
    }
}
