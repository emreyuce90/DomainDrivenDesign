using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Users;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Users.Create; 
public sealed record CreateUserCommand(string name,string email,string password,string city, string street, string postalCode, string fullAddress):IRequest<bool>;


 internal sealed class CreateUserCommandHandler(IUnitOfWork unitOfWork,IUserRepository userRepository) : IRequestHandler<CreateUserCommand, bool> {
    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken) {
        bool isSuccess = await userRepository.CreateAsync(request.name, request.email, request.password, request.city,request.street, request.fullAddress, request.postalCode,cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return isSuccess;
    }
}
