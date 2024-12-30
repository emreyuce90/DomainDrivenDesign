using DomainDrivenDesign.Domain.Orders;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Orders.GetAllOrder {
    internal sealed class GetAllOrderQueryHandler(IOrderRepository orderRepository) : IRequestHandler<GetAllOrderQuery, List<Order>> {
        public async Task<List<Order>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken) {
            return await orderRepository.GetAllAsync(cancellationToken);
        }
    }
}
