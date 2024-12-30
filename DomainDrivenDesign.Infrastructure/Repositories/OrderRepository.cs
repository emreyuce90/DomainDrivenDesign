using DomainDrivenDesign.Domain.Orders;
using DomainDrivenDesign.Infrastructure.Context;

namespace DomainDrivenDesign.Infrastructure.Repositories {
    public sealed class OrderRepository(AppDbContext context) : IOrderRepository {
        public async Task<Order> CreateOrder(List<OrderLineDto> orderLineDtos, CancellationToken cancellationToken = default) {
            Order o = new Order(Guid.NewGuid(),1,DateTime.UtcNow,OrderStatus.Pending);
            o.CreateOrderLine(orderLineDtos);
            await context.Orders.AddAsync(o);
            return o;
        }

        public Task<List<Order>> GetAllAsync(CancellationToken cancellationToken = default) {
            throw new NotImplementedException();
        }
    }
}
