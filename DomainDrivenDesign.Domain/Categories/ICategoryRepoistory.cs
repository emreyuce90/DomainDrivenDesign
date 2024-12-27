namespace DomainDrivenDesign.Domain.Categories {
    public interface ICategoryRepoistory {
        Task<List<Category>> GetCategoriesAsync(CancellationToken cancellationToken=default);
        Task CreateCategory(string categoryName,CancellationToken cancellationToken= default);
    }
}
