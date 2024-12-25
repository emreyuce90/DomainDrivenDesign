using DomainDrivenDesign.Domain.Categories;

namespace DomainDrivenDesign.Domain.Products {
    public sealed class Product {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public float Price { get; set; }
        public string Currency { get; set; } = default!;
        public int Stock { get; set; }
        public Category Category { get; set; } = default!;
        public Guid CategoryId { get; set; }
    }
}
