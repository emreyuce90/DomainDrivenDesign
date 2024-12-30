using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Categories;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Categories.Create {
    public sealed record CreateCategoryCommand(string categoryName):IRequest<bool>;



    public class CreateCategoryCommandHandler(ICategoryRepository categoryRepository,IUnitOfWork unitOfWork) : IRequestHandler<CreateCategoryCommand, bool> {
        
        public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken) {
            bool isSucess = await categoryRepository.CreateCategory(request.categoryName, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return isSucess;

        }

    }
}
