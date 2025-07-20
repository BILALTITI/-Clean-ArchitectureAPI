using Microsoft.Extensions.DependencyInjection;
using School_Project.Data.Entity;
using School_Project.Infrastructure.Abstract;
using School_Project.Infrastructure.InfrastructureBases;
using School_Project.Infrastructure.Repository;

namespace School_Project.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            return services;
        }
    }
}
