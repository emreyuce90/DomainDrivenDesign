using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Users;

namespace DomainDrivenDesign.Domain.Categories {
    public sealed class Category :Entity{

        private Category(Guid id):base(id) {
            
        }
        public Category(Guid id,Name name) :base(id){
            Name = name;
        }

        public Name Name { get; private set; } = default!;
        public ICollection<Product> Products { get; set; }

        public void UpdateName(string name) { 
        
            Name = new Name(name);
        }

        public static Category Create(string name) => new Category(Guid.NewGuid(), new Name(name));
    }
}
