using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Categories {
    public sealed class Category :Entity{
        public Category(Guid id,Name name, ICollection<Product> products) :base(id){
            Name = name;
            Products = products;
        }

        public Name Name { get; private set; } = default!;
        public ICollection<Product> Products { get; set; }

        public void UpdateName(string name) { 
        
            Name = new Name(name);
        
        }
    }
}
