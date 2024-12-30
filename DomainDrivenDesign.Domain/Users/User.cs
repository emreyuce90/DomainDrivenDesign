using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Users;

namespace DomainDrivenDesign.Domain.Users {
    public sealed class User : Entity {
        public User(Guid id, Name name, Email email, Password password,Address address) : base(id) {
            Name = name;
            Email = email;
            Password = password;
        }


        public Name Name { get; private set; } = default!;
        public Email Email { get; private set; } = default!;
        public Password Password { get; private set; } = default!;
        public Address Address { get; private set; } = default!;

        //Clasımıza dışarıdan müdehaleyi kapattığımız için güncelleme durumlarını burada ele alırız

        public void UpdateName(string name) {
            Name = new Name(name);
        }

        public void UpdateEmail(string email) {
            Email = new Email(email);
        }

        public void UpdatePassword(string password) { 
        
            Password = new Password(password);
        }

        public void UpdateAddress(string city,string street,string postalCode,string fullAddress) {
            Address = new(city, street, fullAddress, postalCode);
        }
        
    }




    }
