using Microsoft.EntityFrameworkCore;
using TimeTracker.DataAccess.Entities;
using TimeTracker.DataAccess.Interfaces.Repositories;
using TimeTracker.DataAccess.Repositories.Base;
using System.Threading.Tasks;

namespace TimeTracker.DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {
        public UserRepository(TimeTrackerDbContext quizContext) : base(quizContext)
        {

        }

        public async Task<UserEntity> GetByLoginAsync(string login)
        {
            return await QuizContext.Set<UserEntity>().FirstOrDefaultAsync(x => x.Login == login);
        }
    }
}
