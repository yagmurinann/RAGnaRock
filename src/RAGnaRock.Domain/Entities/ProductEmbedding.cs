namespace RAGnaRock.Domain.Entities;

public class ProductEmbedding
{
    public int Id { get; set; }
    public string Vector { get; set; } = string.Empty;

    public int ProductId { get; set; }
    public Product? Product { get; set; }
}
