using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Categories;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Products {
    public sealed class Product:Entity {

        private Product(Guid id) : base(id) {
          
        }
        public Product(Guid id,Name name, Money price, int stock, Guid categoryId):base(id) {
            Name = name;
            Price = price;
            Stock = stock;
            CategoryId = categoryId;
        }

        public Name Name { get; private set; } = default!;
        public Money Price { get; private set; }
        public int Stock { get; private set; }
        public Category Category { get; private set; } = default!;
        public Guid CategoryId { get; private set; }


        public void UpdateProduct(string name, float amount, string currency, int stock, Guid categoryId) { 
        
            Name = new Name(name);
            Price = new Money(amount, Currency.FromCode(currency));
            Stock = stock;
            CategoryId= categoryId;
        
        }

        public static Product CreateProduct(string name, float price, int stock, Guid categoryId, string currency) {
            var p = new Product(Guid.NewGuid(),new Name(name),new Money(price,Currency.FromCode(currency)),stock,categoryId);
            return p;
        }
    }
}
