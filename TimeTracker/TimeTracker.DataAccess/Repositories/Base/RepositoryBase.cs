using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeTracker.DataAccess.Interfaces.Repositories.Base;

namespace TimeTracker.DataAccess.Repositories.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected TimeTrackerDbContext QuizContext { get; set; }

        public RepositoryBase(TimeTrackerDbContext moviesContext)
        {
            QuizContext = moviesContext;
        }

        public void Add(T entity)
        {
            QuizContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            QuizContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            QuizContext.Set<T>().Update(entity);
        }

        public async Task SaveChangesAsync()
        {
            await QuizContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await QuizContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await QuizContext.Set<T>().FindAsync(id);
        }

        public async Task<bool> IsExistAsync(int id)
        {
           return (await QuizContext.Set<T>().FindAsync(id)) != null;
        }
    }
}
