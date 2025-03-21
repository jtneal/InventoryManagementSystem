using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.DAL
{
    public class ProductEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int ProductID { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required int InStock { get; set; }
        public required int Min { get; set; }
        public required int Max { get; set; }
    }
}
