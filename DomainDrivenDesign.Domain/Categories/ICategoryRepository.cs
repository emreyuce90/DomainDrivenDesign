namespace DomainDrivenDesign.Domain.Categories {
    public interface ICategoryRepository {
        Task<List<Category>> GetCategoriesAsync(CancellationToken cancellationToken=default);
        Task<Category> CreateCategory(string categoryName,CancellationToken cancellationToken= default);
    }
}
