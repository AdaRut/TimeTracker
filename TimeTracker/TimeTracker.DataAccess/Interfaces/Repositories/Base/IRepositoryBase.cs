using System.Collections.Generic;
using System.Threading.Tasks;

namespace TimeTracker.DataAccess.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> IsExistAsync(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}
