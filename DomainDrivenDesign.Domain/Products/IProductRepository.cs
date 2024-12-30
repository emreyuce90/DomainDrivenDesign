using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Products {
    public interface IProductRepository {
        Task<List<Product>> GetAllAsync(CancellationToken cancellationToken=default);
        Task<bool> CreateProduct(string name, float price, int stock, Guid categoryId, string currency, CancellationToken cancellationToken = default);
    }
}
