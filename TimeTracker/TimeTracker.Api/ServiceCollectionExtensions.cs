
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TimeTracker.DataAccess;
using TimeTracker.DataAccess.Interfaces.Repositories;
using TimeTracker.DataAccess.Repositories;
using TimeTracker.Services.Interfaces.Services.Utils;
using TimeTracker.Services.Mapper;
using TimeTracker.Services.Services.Utils;

namespace TimeTracker.Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<TimeTrackerDbContext>(options =>
              options.UseSqlServer(connectionString));
            return services;
        }

        public static IServiceCollection AddMappingServices(this IServiceCollection services)
        {
            services.AddSingleton<Profile, UserProfile>();
            services.AddSingleton<IConfigurationProvider, AutoMapperConfiguration>(p =>
                    new AutoMapperConfiguration(p.GetServices<Profile>()));
            services.AddSingleton<IMapper, Mapper>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddScoped<IHashService, HashService>();
            services.AddScoped<ITokenGeneratorService, TokenGeneratorService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAuthProvider, AuthProvider>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            return services;
        }
    }
}
