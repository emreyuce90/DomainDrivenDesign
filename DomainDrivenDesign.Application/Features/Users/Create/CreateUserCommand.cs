using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Users;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Users.Create; 
public sealed record CreateUserCommand(string name,string email,string password,string city, string street, string postalCode, string fullAddress):IRequest<User>;


 internal sealed class CreateUserCommandHandler(IUnitOfWork unitOfWork,IUserRepository userRepository,IMediator mediator) : IRequestHandler<CreateUserCommand, User> {
    public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken) {
        var user = await userRepository.CreateAsync(request.name, request.email, request.password, request.city,request.street, request.fullAddress, request.postalCode,cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        await mediator.Publish(user,cancellationToken);
        return user;
    }
}
