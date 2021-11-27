using AutoMapper;
using System.Threading.Tasks;
using TimeTracker.DataAccess.Interfaces.Repositories;
using TimeTracker.Services.Interfaces.Services.Utils;
using TimeTracker.Services.Models.User;

namespace TimeTracker.Services.Services.Utils
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository userRepository;
        private readonly IHashService hashService;
        private readonly ITokenGeneratorService tokenGeneratorService;
        private readonly IMapper mapper;
        private readonly IAuthProvider authProvider;

        public AuthService(
            IUserRepository userRepository,
            IHashService hashService,
            ITokenGeneratorService tokenGeneratorService,
            IMapper mapper,
            IAuthProvider authProvider)
        {
            this.userRepository = userRepository;
            this.hashService = hashService;
            this.tokenGeneratorService = tokenGeneratorService;
            this.mapper = mapper;
            this.authProvider = authProvider;
        }

        public async Task<AuthData> LoginAsync(UserLogin userLogin)
        {
            var userEnity = await userRepository.GetByLoginAsync(userLogin.Login);
            if (userEnity != null)
            {
                bool passwordIsCorrect = true; //hashService.Validate(userLogin.Password, userEnity.Password);
                if (passwordIsCorrect)
                {
                    var token = tokenGeneratorService.GenerateToken(userEnity.Id);
                    var user = mapper.Map<User>(userEnity);
                    return new AuthData
                    {
                        Token = token,
                        User = user
                    };
                }
            }
            return null;
        }
    }
}
