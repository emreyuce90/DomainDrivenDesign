using DomainDrivenDesign.Domain.Products;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Products.CreateProduct {
    public sealed record CreateProductCommand(string name, float price, int stock, Guid categoryId,string currency):IRequest<Product>;
}
