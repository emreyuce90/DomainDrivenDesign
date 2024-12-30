using MediatR;

namespace DomainDrivenDesign.Domain.Orders.Events {
    public class SendSMSAfterOrder : INotificationHandler<OrderCreatedEvent> {
        public Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken) {
            //SMS gönderme işlemleri
            return Task.CompletedTask;
        }
    }
}
