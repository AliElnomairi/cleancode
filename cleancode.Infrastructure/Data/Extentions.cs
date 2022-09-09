using cleancode.Application.Repositories;
using cleancode.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Infrastructure.Data
{
    public static class Extentions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IParkingRepositories, ParkingRepositories>();
            services.AddScoped<ICarRepositories,CarRepositories>();
            services.AddScoped<IEmployeeRepositories, EmployeeRepositories>();  
            return services;
        }
    }
}
