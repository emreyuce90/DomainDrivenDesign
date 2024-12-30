using MediatR;

namespace DomainDrivenDesign.Domain.Orders.Events {
    public class SendEmailAfterOrder : INotificationHandler<OrderCreatedEvent> {
        public Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken) {
            //E-posta gönderme işlemleri
            return Task.CompletedTask;
        }
    }
}
