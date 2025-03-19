using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JasonNealC968.Models;

public class Part
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PartID { get; set; }
    public required string Name { get; set; }
    public int Inventory { get; set; }
    public decimal Price { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }
    public string? Category { get; set; }
    public string? MachineId { get; set; }
    public string? CompanyName { get; set; }
}
