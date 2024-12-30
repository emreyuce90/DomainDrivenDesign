using DomainDrivenDesign.Application.Features.Categories.DTOs;
using DomainDrivenDesign.Domain.Categories;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Categories.GetAllCategories;

internal sealed class GetAllCategoryQueryHandler(ICategoryRepository categoryRepoistory) : IRequestHandler<GetAllCategoryQuery, List<CategoryDto>> {
    public async Task<List<CategoryDto>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken) {
        var categories = await categoryRepoistory.GetCategoriesAsync(cancellationToken);
        var categoryListDto = categories.Select(c => new CategoryDto() { Id = c.Id,Name = c.Name.Value});
        return categoryListDto.ToList(); 
    }
}
