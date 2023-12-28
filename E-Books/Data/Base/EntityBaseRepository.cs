using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace E_Books.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(a => a.Id == Id);
            if (entity == null)
                return;
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetPageAsync(int? pageNumber, int pageSize)
        {
            var result = await _context.Set<T>().Skip((int)((pageNumber - 1) * pageSize)).Take(pageSize).ToListAsync();
            return result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(a => a.Id == id);
            return result;
        }

        public async Task<int> TotalPages(int pageSize)
        {
            int count = await _context.Set<T>().CountAsync();
            int totalPages = (int)Math.Ceiling(count / (double)pageSize);
            return totalPages;
        }

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
