using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;

namespace DomainDrivenDesign.Domain.Categories {
    public sealed class Category :Entity{
        public Category(Guid id,Name name) :base(id){
            Name = name;
        }

        public Name Name { get; private set; } = default!;
        public ICollection<Product> Products { get; set; }

        public void UpdateName(string name) { 
        
            Name = new Name(name);
        
        }
    }
}
