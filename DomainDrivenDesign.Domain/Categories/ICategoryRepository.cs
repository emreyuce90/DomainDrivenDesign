namespace DomainDrivenDesign.Domain.Categories {
    public interface ICategoryRepository {
        Task<List<Category>> GetCategoriesAsync(CancellationToken cancellationToken=default);
        Task<bool> CreateCategory(string categoryName,CancellationToken cancellationToken= default);
    }
}
