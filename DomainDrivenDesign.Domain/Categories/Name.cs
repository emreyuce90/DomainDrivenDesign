namespace DomainDrivenDesign.Domain.Categories {
    public sealed record Name {
        public string Value { get; init; }

        public Name(string value) {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Name alanı boş geçilemez");
            if (value.Length < 2) throw new ArgumentException("Name alanı en az 3 karakter olmalıdır");
            Value = value;
        }
    }
}
