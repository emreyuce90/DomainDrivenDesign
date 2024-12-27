namespace DomainDrivenDesign.Domain.Orders {
    public interface IOrderRepository {
        Task<List<Order>> GetAllAsync(CancellationToken cancellationToken=default);
        Task CreateOrder(List<OrderLineDto> orderLineDtos, CancellationToken cancellationToken=default);
    }
}
