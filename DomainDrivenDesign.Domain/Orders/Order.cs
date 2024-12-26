using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Orders {
    public sealed class Order : Entity {
        public Order(Guid id,int orderNumber, DateTime createdDate, ICollection<OrderLine> orderLines, OrderStatus orderStatus) :base(id){
            OrderNumber = orderNumber;
            CreatedDate = createdDate;
            OrderLines = orderLines;
            OrderStatus = orderStatus;
        }

        public int OrderNumber { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public ICollection<OrderLine> OrderLines { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
    }
}
