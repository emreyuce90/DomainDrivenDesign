namespace DomainDrivenDesign.Domain.Products {
    public sealed record Name {
        public string Value { get; set; }
        public Name(string value) {
            Value = value;
        }
    }
}
