using Microsoft.Extensions.DependencyInjection;
using School_Project.Data.Entity;
using School_Project.Infrastructure.Abstract;
using School_Project.Service.Abstracts;
using School_Project.Service.Implemantions;

namespace School_Project.Service
{
    public static  class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IstudentSrvice, StudentsService>();
            return services;
        }

    }
}
