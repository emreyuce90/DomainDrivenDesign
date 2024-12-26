namespace DomainDrivenDesign.Domain.Users {
    public sealed record Email {
        public string Value { get; init; }

        public Email(string value) {
            if(string.IsNullOrEmpty(value)) throw new ArgumentNullException("EMail boş geçilemez");
            if (!value.Contains("@")) throw new ArgumentException("Lütfen geçerli bir email adresi giriniz");
            Value = value;
        }

    }
}
