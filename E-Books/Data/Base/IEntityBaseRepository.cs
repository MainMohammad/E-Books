using E_Books.Models;
using System.Linq.Expressions;

namespace E_Books.Data.Base
{
    public interface IEntityBaseRepository <T> where T : class, IEntityBase, new() 
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int Id);

    }
}
