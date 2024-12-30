using DomainDrivenDesign.Domain.Users;
using DomainDrivenDesign.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Infrastructure.Repositories {
    public sealed class UserRepository(AppDbContext context) : IUserRepository {
        public async Task<User> CreateAsync(string name, string email, string password, string City, string Street, string FullAddress, string PostalCode, CancellationToken cancellationToken = default) {
            User user = User.CreateUser(name,email,password,City,Street,FullAddress,PostalCode);
            await context.Users.AddAsync(user,cancellationToken);
            return user;

        }

        public async Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default) {
            return await context.Users.ToListAsync(cancellationToken);
        }
    }
}
