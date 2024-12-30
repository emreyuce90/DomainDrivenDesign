using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DomainDrivenDesign.Application {
    public static class ApplicationIoc {
        public static IServiceCollection AddApplicationDependenciesExt(this IServiceCollection services) {

            //MediatR IoC Apply
            services.AddMediatR(configuration => {
                configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });
            return services;
        }
    }
}
