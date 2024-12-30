using DomainDrivenDesign.Application.Features.Users.Dtos;
using DomainDrivenDesign.Domain.Users;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Users.GetAllUser {
    internal sealed class GetAllUserQueryHandler(IUserRepository userRepository) : IRequestHandler<GetAllUserQuery, List<UserDto>> {
        public async Task<List<UserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken) {
            var users = await userRepository.GetAllAsync(cancellationToken);
           
            List<UserDto> userListDto = new();
            foreach (var u in users) {
               var newDto = new UserDto() {
                    Id = u.Id,
                    Name = u.Name.Value,
                    Email = u.Email.Value,
                };
                userListDto.Add(newDto);
            }
            return userListDto;
        }
    }
}
