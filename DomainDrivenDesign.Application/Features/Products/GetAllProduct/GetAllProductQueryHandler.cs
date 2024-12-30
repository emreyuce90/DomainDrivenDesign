using DomainDrivenDesign.Application.Features.Products.Dtos;
using DomainDrivenDesign.Domain.Products;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Products.GetAllProduct {
    internal sealed class GetAllProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetAllProductQuery, List<ProductDto>> {
        public async Task<List<ProductDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken) {
            var allProducts = await productRepository.GetAllAsync(cancellationToken);
            return allProducts.Select(p=> new ProductDto() { CategoryId=p.CategoryId,Id = p.Id,Name = p.Name.Value,Price=p.Price.amount,Stock=p.Stock}).ToList();
        }
    }
}
