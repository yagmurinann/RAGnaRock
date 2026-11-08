using Microsoft.AspNetCore.Identity;

namespace RAGnaRock.Domain.Entities;

public class User : IdentityUser<int>
{
    public string FullName { get; set; } = string.Empty;

    public List<Order> Orders { get; set; } = new();
    public Cart? Cart { get; set; }
}
