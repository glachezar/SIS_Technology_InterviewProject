using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

[Table("Products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("ProductName", TypeName = "nvarchar(90)")]
    public string ProductName { get; set; } = null!;

    [Column("Category", TypeName = "nvarchar(90)")]
    public string Category { get; set; } = String.Empty;

    [Column("UnitPrice")]
    public decimal UnitPrice { get; set; }

    [Column("DateAdded")]
    public DateTime DateAdded { get; set; }
}
