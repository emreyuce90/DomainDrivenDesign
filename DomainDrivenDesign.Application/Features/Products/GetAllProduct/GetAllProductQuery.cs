using DomainDrivenDesign.Application.Features.Products.Dtos;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Products.GetAllProduct {
    public sealed record GetAllProductQuery:IRequest<List<ProductDto>>;
}
