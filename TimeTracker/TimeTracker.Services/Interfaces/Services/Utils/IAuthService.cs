using System.Threading.Tasks;
using TimeTracker.Services.Models.User;

namespace TimeTracker.Services.Interfaces.Services.Utils
{
    public interface IAuthService
    {
        Task<AuthData> LoginAsync(UserLogin userLogin);
    }
}
