using E_Books.Data.Base;
using E_Books.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Books.Data.Services
{
    public class AuthorsService : EntityBaseRepository<Author>, IAuthorsServices
    {
        public AuthorsService(AppDbContext context) : base(context) { }
    }
}
