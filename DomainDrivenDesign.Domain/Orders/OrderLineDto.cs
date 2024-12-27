namespace DomainDrivenDesign.Domain.Orders {
    public sealed record OrderLineDto(Guid productId,float price,int quantity,string currency);
       

}
