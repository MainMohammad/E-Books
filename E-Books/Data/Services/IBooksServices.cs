using E_Books.Data.Base;
using E_Books.Data.ViewModels;
using E_Books.Models;
using System.Linq.Expressions;

namespace E_Books.Data.Services
{
    public interface IBooksServices : IEntityBaseRepository<Book> 
    {
        Task<Book> GetBookById(int id);
        Task<NewBookDropdownsVM> GetNewBookDropdownVals();
        Task AddNewBook(NewBookVM data);
        Task<IEnumerable<Book>> GetBooksByPublisherId(int Id);
    }
}
