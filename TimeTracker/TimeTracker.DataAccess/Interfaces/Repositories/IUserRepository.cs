using System.Threading.Tasks;
using TimeTracker.DataAccess.Entities;
using TimeTracker.DataAccess.Interfaces.Repositories.Base;

namespace TimeTracker.DataAccess.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<UserEntity>
    {
        Task<UserEntity> GetByLoginAsync(string login);
    }
}
