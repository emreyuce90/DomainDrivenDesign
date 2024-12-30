using DomainDrivenDesign.Application.Features.Categories.DTOs;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Categories.GetAllCategories;
public sealed record GetAllCategoryQuery:IRequest<List<CategoryDto>>;
