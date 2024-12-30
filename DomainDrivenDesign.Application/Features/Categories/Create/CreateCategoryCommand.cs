using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Categories;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Categories.Create {
    public sealed record CreateCategoryCommand(string categoryName):IRequest<Category>;



    public class CreateCategoryCommandHandler(ICategoryRepository categoryRepository,IUnitOfWork unitOfWork) : IRequestHandler<CreateCategoryCommand, Category> {
        
        public async Task<Category> Handle(CreateCategoryCommand request, CancellationToken cancellationToken) {
            var category = await categoryRepository.CreateCategory(request.categoryName, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return category;

        }

    }
}
