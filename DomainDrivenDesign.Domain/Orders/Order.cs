using DomainDrivenDesign.Domain.Products;

namespace DomainDrivenDesign.Domain.Orders {
    public sealed class Order {
        public Guid Id { get; set; }
        public int OrderNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }

    public sealed class OrderLine {

        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Currency { get; set; }

    }


    public enum OrderStatus {
        Pending = 0,
        Approved=1,
        Rejected =2,
        Delivered =3,
        Succeeded=4
    }
}
