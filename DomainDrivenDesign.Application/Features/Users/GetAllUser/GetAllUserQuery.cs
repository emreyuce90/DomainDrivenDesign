using DomainDrivenDesign.Application.Features.Users.Dtos;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Users.GetAllUser {
    public sealed record GetAllUserQuery:IRequest<List<UserDto>>;
}
