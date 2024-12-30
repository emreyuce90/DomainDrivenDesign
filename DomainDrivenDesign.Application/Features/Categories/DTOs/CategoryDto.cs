namespace DomainDrivenDesign.Application.Features.Categories.DTOs {
    public sealed class CategoryDto {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
