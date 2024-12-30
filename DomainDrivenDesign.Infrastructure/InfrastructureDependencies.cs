using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Categories;
using DomainDrivenDesign.Domain.Orders;
using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Users;
using DomainDrivenDesign.Infrastructure.Context;
using DomainDrivenDesign.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DomainDrivenDesign.Infrastructure {
    public static class InfrastructureDependencies {
        public static IServiceCollection AddInfraDependenciesExt(this IServiceCollection services, string connectionString) {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<AppDbContext>());
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
                

            return services;
        }
    }
}
