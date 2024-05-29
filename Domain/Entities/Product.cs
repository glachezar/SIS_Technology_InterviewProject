namespace Domain;

public class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string Category { get; set; } = String.Empty;

    public decimal UnitPrice { get; set; }

    public DateTime DateAdded { get; set; }
}

