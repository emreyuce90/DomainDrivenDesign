namespace DomainDrivenDesign.Domain.Users {
    public sealed record Password {
        public string Value { get; init; }

        public Password(string value) {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Şifre alanı boş geçilemez");
            if (value.Length < 5) throw new ArgumentException("Şifre alanı en az 6 karakter içermelidir");
            Value = value;
        }
    }
}
