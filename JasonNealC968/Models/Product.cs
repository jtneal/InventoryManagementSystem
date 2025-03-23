using System.ComponentModel;

namespace JasonNealC968.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = [];
        public int ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
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
            AssociatedParts.Remove(lookupAssociatedPart(partID));

            return true;
        }

        public Part lookupAssociatedPart(int partID)
        {
            return AssociatedParts.First(x => x.PartID == partID);
        }
    }
}
