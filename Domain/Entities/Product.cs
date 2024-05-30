using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

[Table("Products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("ProductName", TypeName = "nvarchar(90)")]
    public string ProductName { get; set; } = null!;

    public string Category { get; set; } = String.Empty;

    public decimal UnitPrice { get; set; }

    public DateTime DateAdded { get; set; }
}

