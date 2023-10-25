using E_Books.Models;

namespace E_Books.Data.Services
{
    public interface IAuthorsServices
    {
        Task <IEnumerable<Author>> GetAll();
        Task <Author> GetByIdAsync(int id);
        Task AddAsync(Author author);
        Task <Author> UpdateAsync(int id, Author newAuthor);
        void Delete(int id);
    }
}
