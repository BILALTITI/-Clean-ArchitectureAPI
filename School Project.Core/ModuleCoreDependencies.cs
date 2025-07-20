using Microsoft.Extensions.DependencyInjection;
using School_Project.Service.Abstracts;
using School_Project.Service.Implemantions;
using System.Reflection;

namespace School_Project.Core
{

    public static class ModuleCoreDependencies
    {


        #region Fileds

        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)

        {

// configration of meditor
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            // configration of Auto Mapper 
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
        #endregion
     

    }
}
