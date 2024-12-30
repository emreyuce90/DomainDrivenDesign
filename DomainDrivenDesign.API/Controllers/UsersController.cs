using DomainDrivenDesign.Application.Features.Users.Create;
using DomainDrivenDesign.Application.Features.Users.GetAllUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DomainDrivenDesign.API.Controllers {
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController(IMediator mediator) : ControllerBase {

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand createUserCommand,CancellationToken cancellationToken) {
            await mediator.Send(createUserCommand,cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllUserQuery query, CancellationToken cancellationToken) {
            var allUsers = await mediator.Send(query, cancellationToken);
            return Ok(allUsers);
        }
    }
}
