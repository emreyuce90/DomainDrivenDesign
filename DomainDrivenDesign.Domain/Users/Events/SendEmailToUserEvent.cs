using MediatR;

namespace DomainDrivenDesign.Domain.Users.Events {
    public class SendEmailToUserEvent : INotificationHandler<UserCreatedEvent> {
        public Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }
}
