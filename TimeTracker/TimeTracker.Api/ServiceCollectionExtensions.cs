
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TimeTracker.DataAccess;

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
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            return services;
        }
    }
}
