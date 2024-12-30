namespace DomainDrivenDesign.Application.Features.Products.Dtos {
    public sealed class ProductDto {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public Guid CategoryId { get; set; }
    }
}
