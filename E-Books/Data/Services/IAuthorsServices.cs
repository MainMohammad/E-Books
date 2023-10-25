using E_Books.Models;

namespace E_Books.Data.Services
{
    public interface IAuthorsServices
    {
        Task <IEnumerable<Author>> GetAll();
        Author GetById(int id);
        Task AddAsync(Author author);
        Author Update(int id, Author newAuthor);
        void Delete(int id);
    }
}
