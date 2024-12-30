using DomainDrivenDesign.Domain.Orders;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Orders.CreateOrder {
    public sealed record CreateOrderCommand(List<OrderLineDto> orderLineDtos):IRequest<Order>;
}
