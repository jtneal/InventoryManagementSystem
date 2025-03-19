using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JasonNealC968.Models;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductID { get; set; }
    public required string Name { get; set; }
    public int Inventory { get; set; }
    public decimal Price { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }
}
