using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Categories;
using DomainDrivenDesign.Domain.Orders;
using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Shared;
using DomainDrivenDesign.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Infrastructure.Context {
    public class AppDbContext : DbContext,IUnitOfWork {
        public AppDbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //Userin içerisinde Value değeri olduğu için Db ye Value yu yazdırıyorum ,geldiğinde de çevir
            modelBuilder.Entity<User>().Property(u => u.Name).HasConversion(name => name.Value, value => new(value));
            modelBuilder.Entity<User>().Property(u => u.Email).HasConversion(email => email.Value, value => new(value));
            modelBuilder.Entity<User>().Property(u => u.Password).HasConversion(pass => pass.Value, value => new(value));
            modelBuilder.Entity<User>().OwnsOne(p => p.Address);

            modelBuilder.Entity<Category>().Property(u => u.Name).HasConversion(name => name.Value, value => new(value));

            modelBuilder.Entity<Product>().Property(u => u.Name).HasConversion(name => name.Value, value => new(value));
           //Fiyat alanı ve döviz alanlarının ef core a tanıtılması
            modelBuilder.Entity<Product>().OwnsOne(p => p.Price, priceBuilder => {
                priceBuilder.Property(x => x.Currency).HasConversion(curr => curr.Code, code => Currency.FromCode(code));
                priceBuilder.Property(x => x.amount).HasColumnType("money");
            });


            modelBuilder.Entity<OrderLine>().OwnsOne(p => p.Price, priceBuilder => {
                priceBuilder.Property(x => x.Currency).HasConversion(curr => curr.Code, code => Currency.FromCode(code));
                priceBuilder.Property(x => x.amount).HasColumnType("money");
            });
        }
    }
}
