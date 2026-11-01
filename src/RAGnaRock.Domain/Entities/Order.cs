namespace RAGnaRock.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }

    public List<OrderItem> Items { get; set; } = new();
}

public enum OrderStatus
{
    Pending,
    Completed,
    Cancelled
}
