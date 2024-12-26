namespace DomainDrivenDesign.Domain.Shared {
    public sealed record Currency {
        //Currency.TRY = try
        //Currency.USD = usd

        public static readonly Currency TRY = new("try");
        public static readonly Currency USD = new("usd");

        public static readonly IReadOnlyCollection<Currency> All = new[] { USD, TRY };

        public string Code { get; init; }

        public Currency(string code) {
            Code = code;
        }

        public static Currency FromCode(string code) {

            return All.FirstOrDefault(c => c.Code == code) ?? throw new ArgumentException("Lütfen geçerli bir para birimi giriniz");
        }
    }
}
