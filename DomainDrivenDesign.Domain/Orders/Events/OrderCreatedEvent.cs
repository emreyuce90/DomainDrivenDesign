using MediatR;

namespace DomainDrivenDesign.Domain.Orders.Events {
    public sealed class OrderCreatedEvent:INotification {
        public Order Order { get; }
        public OrderCreatedEvent(Order order) {
            Order = order;
        }
    }
}
