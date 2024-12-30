using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Products.CreateProduct {
    internal sealed class CreateProductCommandHandler(IProductRepository productRepository,IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, Product> {
        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken) {
            var product = await productRepository.CreateProduct(request.name,request.price,request.stock,request.categoryId,request.currency,cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return product;
        }
    }
}
