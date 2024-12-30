using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Infrastructure.Repositories {
    public sealed class ProductRepository(AppDbContext context) : IProductRepository {
        public async Task<Product> CreateProduct(string name, float price, int stock, Guid categoryId, string currency, CancellationToken cancellationToken = default) {
            var product = Product.CreateProduct(name, price, stock, categoryId, currency);
            await context.Products.AddAsync(product,cancellationToken);
            return product;
        }

        public async Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default) {
            return await context.Products.ToListAsync();
        }
    }
}
