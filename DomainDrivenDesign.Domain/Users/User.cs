﻿namespace DomainDrivenDesign.Domain.Users {
    public sealed class User {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string FullAddress { get; set; } = default!;
        public string PostalCode { get; set; } = default!;

    }
}
