using JasonNealC968.Constants;
using JasonNealC968.Mappers;
using JasonNealC968.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.DAL
{
    public class Inventory
    {
        public BindingList<Product> Products = [];
        public BindingList<Part> AllParts = [];
        private InventoryContext context;

        public Inventory(InventoryContext context)
        {
            this.context = context;
        }

        public void addProduct(Product product)
        {
            context.Products.Add(new ProductEntity()
            {
                Name = product.Name,
                Price = product.Price,
                InStock = product.InStock,
                Min = product.Min,
                Max = product.Max,
            });
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
            var product = new Product();
            var productEntity = context.Products.Find(productID);

            if (productEntity is not null)
            {
                product.ProductID = productEntity.ProductID;
                product.Name = productEntity.Name;
                product.Price = productEntity.Price;
                product.InStock = productEntity.InStock;
                product.Min = productEntity.Min;
                product.Max = productEntity.Max;
            }

            return product;
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

            productEntity.ProductID = product.ProductID;
            productEntity.Name = product.Name;
            productEntity.Price = product.Price;
            productEntity.InStock = product.InStock;
            productEntity.Min = product.Min;
            productEntity.Max = product.Max;

            context.Products.Update(productEntity);
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
            {
                Part part = partEntity.Category == PartCategory.Outsourced
                    ? new Outsourced() { CompanyName = partEntity.CompanyName ?? string.Empty }
                    : new Inhouse() { MachineID = partEntity.MachineID ?? 0 };

                part.PartID = partEntity.PartID;
                part.Name = partEntity.Name;
                part.Price = partEntity.Price;
                part.InStock = partEntity.InStock;
                part.Min = partEntity.Min;
                part.Max = partEntity.Max;
                part.Category = partEntity.Category;

                return part;
            }

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
