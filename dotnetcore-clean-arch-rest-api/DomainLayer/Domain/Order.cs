namespace Domain;

public class Order
{
    public int Id { get; set; }
    public required string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public required Customer Customer { get; set; }
    public required List<OrderItem> OrderItems { get; set; }
}

