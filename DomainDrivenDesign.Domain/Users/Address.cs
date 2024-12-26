namespace DomainDrivenDesign.Domain.Users {
    //value objects

    public sealed record Address(string City, string Street, string FullAddress, string PostalCode);
}
