using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Orders;
using DomainDrivenDesign.Domain.Orders.Events;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Orders.CreateOrder {
    internal sealed class CreateOrderCommandHandler(IOrderRepository orderRepository, IUnitOfWork unitOfWork,IMediator mediator) : IRequestHandler<CreateOrderCommand, Order> {
        public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken) {
            var order = await orderRepository.CreateOrder(request.orderLineDtos, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            await mediator.Publish(new OrderCreatedEvent(order),cancellationToken);
            return order;

        }
    }
}
