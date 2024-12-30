namespace DomainDrivenDesign.Domain.Orders {
    public interface IOrderRepository {
        Task<List<Order>> GetAllAsync(CancellationToken cancellationToken=default);
        Task<Order> CreateOrder(List<OrderLineDto> orderLineDtos, CancellationToken cancellationToken=default);
    }
}
