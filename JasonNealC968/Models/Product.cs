using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = [];
        public int ProductID { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            var part = lookupAssociatedPart(partID);

            AssociatedParts.Remove(part);

            return true;
        }

        public Part lookupAssociatedPart(int partID)
        {
            var part = AssociatedParts.FirstOrDefault((x) => x.PartID == partID);

            if (part is null)
            {
                throw new ArgumentException();
            }

            return part;
        }
    }
}
