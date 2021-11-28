using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TimeTracker.DataAccess.Entities;
using TimeTracker.DataAccess.Interfaces.Repositories;
using TimeTracker.DataAccess.Repositories.Base;

namespace TimeTracker.DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {
        public UserRepository(TimeTrackerDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<UserEntity> GetByLoginAsync(string login)
        {
            return await DbContext.Set<UserEntity>().FirstOrDefaultAsync(x => x.Login == login);
        }
    }
}
