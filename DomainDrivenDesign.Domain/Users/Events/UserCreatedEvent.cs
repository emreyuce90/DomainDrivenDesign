using MediatR;

namespace DomainDrivenDesign.Domain.Users.Events {
    public sealed class UserCreatedEvent:INotification {
        public User User { get; }
        public UserCreatedEvent(User user) {
            User = user;
        }
    }
}
