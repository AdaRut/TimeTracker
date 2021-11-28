using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeTracker.DataAccess.Interfaces.Repositories.Base;

namespace TimeTracker.DataAccess.Repositories.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected TimeTrackerDbContext DbContext { get; set; }

        public RepositoryBase(TimeTrackerDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public void Add(T entity)
        {
            DbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            DbContext.Set<T>().Update(entity);
        }

        public async Task SaveChangesAsync()
        {
            await DbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await DbContext.Set<T>().FindAsync(id);
        }

        public async Task<bool> IsExistAsync(int id)
        {
            return (await DbContext.Set<T>().FindAsync(id)) != null;
        }
    }
}
