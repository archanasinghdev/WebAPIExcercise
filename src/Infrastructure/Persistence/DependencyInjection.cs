using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence.Context
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSQLRepository(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
