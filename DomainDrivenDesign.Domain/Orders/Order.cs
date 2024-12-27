using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Orders {
    public sealed class Order : Entity {
        public Order(Guid id,int orderNumber, DateTime createdDate, OrderStatus orderStatus) :base(id){
            OrderNumber = orderNumber;
            CreatedDate = createdDate;
            OrderStatus = orderStatus;
        }

        public int OrderNumber { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
        public ICollection<OrderLine> OrderLines { get; private set; }

        //Agregate root
        public void CreateOrderLine(List<OrderLineDto> orderLines) {
            //Order nesne örneği alındıktan sonra Order.CreateOrderLine() içerisine List<OrderLineDto> tipinde veri girildiğinde bu lineları classımızın içerisine yazar
            foreach (var line in orderLines) {
                if (line.quantity < 1) {
                    throw new ArgumentException("Girilen miktar sayısı 1'den küçük olamaz");
                }
                var ol = new OrderLine(Guid.NewGuid(),Id,line.productId,line.quantity,new Money(line.price,Currency.FromCode(line.currency)));
                OrderLines.Add(ol);
            }
        }

        public void DeleteOrderLineItem(Guid orderlineId) {
            var orderLine = OrderLines.FirstOrDefault(ol => ol.Id == orderlineId);
            if (orderLine is null) throw new ArgumentException("Aradığınız order line item mevcut değil");
            OrderLines.Remove(orderLine);
        }

    }
       

}
