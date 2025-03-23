using JasonNealC968.Mappers;
using JasonNealC968.Models;
using System.ComponentModel;

namespace JasonNealC968.DAL
{
    public class Inventory(InventoryContext context)
    {
        public BindingList<Product> Products = [];
        public BindingList<Part> AllParts = [];

        public void addProduct(Product product)
        {
            var newParts = product.AssociatedParts
                .Select(x => new ProductPartsEntity { PartID = x.PartID, ProductID = product.ProductID })
                .ToList();

            context.ProductParts.AddRange(newParts);
            context.Products.Add(ProductMapper.HydrateProductEntity(new ProductEntity(), product));
            context.SaveChanges();
        }

        public bool removeProduct(int productID)
        {
            var productEntity = context.Products.Find(productID);

            if (productEntity is null)
                return false;

            context.Products.Remove(productEntity);
            context.SaveChanges();

            return true;
        }

        public Product lookupProduct(int productID)
        {
            var productEntity = context.Products.Find(productID);

            if (productEntity is not null)
            {
                var product = ProductMapper.ToProductModel(productEntity);

                product.AssociatedParts = new BindingList<Part>(productEntity.AssociatedParts
                    .Select(ap => PartMapper.ToPartModel(context.Parts.First(p => p.PartID == ap.PartID)))
                    .ToList());

                return product;
            }


            return new Product();
        }

        public void updateProduct(int productID, Product product)
        {
            var productEntity = context.Products.Find(productID);

            if (productEntity is null)
            {
                // If the product doesn't exist, let's create it!
                addProduct(product);
                return;
            }

            var currentParts = context.ProductParts.Where(x => x.ProductID == productID).ToList();

            var newParts = product.AssociatedParts.Select(x => new ProductPartsEntity
            {
                PartID = x.PartID,
                ProductID = productID,
            }).ToList();

            context.Products.Update(ProductMapper.HydrateProductEntity(productEntity, product));
            context.ProductParts.RemoveRange(currentParts);
            context.ProductParts.AddRange(newParts);
            context.SaveChanges();
        }

        public void addPart(Part part)
        {
            context.Parts.Add(PartMapper.ToPartEntity(part));
            context.SaveChanges();
        }

        public bool deletePart(Part part)
        {
            var partEntity = context.Parts.Find(part.PartID);

            if (partEntity is null)
                return false;

            context.Parts.Remove(partEntity);
            context.SaveChanges();

            return true;
        }

        public Part lookupPart(int partID)
        {
            var partEntity = context.Parts.Find(partID);

            if (partEntity is not null)
                return PartMapper.ToPartModel(partEntity);

            // We default the category to inhouse for new parts
            return new Inhouse();
        }

        public void updatePart(int partID, Part part)
        {
            var partEntity = context.Parts.Find(partID);

            if (partEntity is null)
            {
                // If the part doesn't exist, let's create it!
                addPart(part);
                return;
            }

            context.Parts.Update(PartMapper.HydratePartEntity(partEntity, part));
            context.SaveChanges();
        }
    }
}
