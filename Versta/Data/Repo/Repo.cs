
using Microsoft.EntityFrameworkCore;
using Versta.Data.Models;

namespace Versta.Data.Repo
{
   
        public class Repo<T> : IRepo<T> where T : class
        {
            AppDbContext _context;
            DbSet<T> _dbSet;
            public Repo(AppDbContext context)
            {
                _context = context;
                _dbSet = context.Set<T>();
            }

            public async Task<T> SaveAsync(T entity)
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }

            public async Task<List<T>> GetAsync()
            {
                return await _context.Set<T>().ToListAsync();
            }
        }
}
