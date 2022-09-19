using cleancode.Application.Repositories;
using cleancode.Infrastructure.Data.Repositories;

using Microsoft.Extensions.DependencyInjection;

namespace cleancode.Infrastructure.Data
{
    public static class Extentions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services.AddScoped<IParkingRepositories, ParkingRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IEmployeeRepositories, EmployeeRepository>();

            services.AddDbContext<AppDbContext>();

            services.AddHostedService<AppInitializer>();

            return services;
        }
    }
}
