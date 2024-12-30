using DomainDrivenDesign.Domain.Categories;
using DomainDrivenDesign.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Infrastructure.Repositories {
    public sealed class CategoryRepository(AppDbContext context) : ICategoryRepository {
        public async Task<Category> CreateCategory(string categoryName, CancellationToken cancellationToken = default) {
            Category c = Category.Create(categoryName);
            await context.Categories.AddAsync(c,cancellationToken);
            return c;
        }

        public async Task<List<Category>> GetCategoriesAsync(CancellationToken cancellationToken = default) {
            return await context.Categories.ToListAsync(cancellationToken);
        }
    }
}
