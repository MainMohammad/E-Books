namespace E_Books.Data.Base
{
    public interface IEntityBaseRepository <T> where T : class, IEntityBase, new() 
    {
        Task<IEnumerable<T>> GetPageAsync(int? pageNumber, int pageSize);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int Id);
        Task<int> TotalPages(int pageSize);
    }
}
