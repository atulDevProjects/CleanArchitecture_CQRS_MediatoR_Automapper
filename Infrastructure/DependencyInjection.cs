using Application.Common.Interfaces;
using Domain.DBEntities;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            EmpDBContext dBContext = new EmpDBContext();

            services.AddScoped(typeof(IEmployeeServiceProvider), typeof(EmployeeServiceProvider));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddSingleton(dBContext);

            return services;
        }

    }
}