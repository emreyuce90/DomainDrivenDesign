namespace DomainDrivenDesign.Domain.Shared {
    public sealed record Money(float amount, Currency Currency) {
        public static Money operator +(Money a, Money b) {

            if (a.Currency != b.Currency) throw new ArgumentException("Para birimleri birbirlerinden farklı değerler toplanamaz");
            return new(a.amount + b.amount, a.Currency);
        }



    }
}
