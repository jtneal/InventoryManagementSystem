using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JasonNealC968.DAL
{
    public class PartEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Category { get; set; } = string.Empty;
        public string? CompanyName { get; set; }
        public int? MachineID { get; set; }
    }
}
