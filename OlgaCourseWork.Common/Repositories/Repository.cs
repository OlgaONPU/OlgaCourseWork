using DataLayer;
using Microsoft.EntityFrameworkCore;
using OlgaCourseWork.Common.Interfaces.Repositories;

namespace OlgaCourseWork.Common.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PrometeiDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(PrometeiDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
