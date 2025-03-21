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
                ProductID = -1, // Auto-generated
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
            var product = context.Products.Find(productID);

            if (product is null)
                return false;

            context.Products.Remove(new ProductEntity()
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Price = product.Price,
                InStock = product.InStock,
                Min = product.Min,
                Max = product.Max,
            });
            context.SaveChanges();

            return true;
        }

        public Product lookupProduct(int productID)
        {
            var product = context.Products.Find(productID);

            if (product is null)
                return new Product();

            return new Product()
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Price = product.Price,
                InStock = product.InStock,
                Min = product.Min,
                Max = product.Max,
            };
        }

        public void updateProduct(int productID, Product product)
        {
            var productEntity = context.Products.Find(productID);

            if (productEntity is null)
            {
                // I could try adding instead
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
            context.Parts.Remove(PartMapper.ToPartEntity(part));
            context.SaveChanges();

            return true;
        }

        public Part lookupPart(int partID)
        {
            var part = context.Parts.Find(partID);

            if (part is null)
                return new Inhouse();

            return new Inhouse()
            {
                PartID = part.PartID,
                Name = part.Name,
                Price = part.Price,
                InStock = part.InStock,
                Min = part.Min,
                Max = part.Max,
            };
        }

        public void updatePart(int partID, Part part)
        {
            var partEntity = context.Parts.Find(partID);

            if (partEntity is null)
            {
                // I don't want to lose data if someone saves and somehow a
                // part no longer existed, so I just create a new one
                addPart(part);
                return;
            }

            context.Parts.Update(PartMapper.HydratePartEntity(partEntity, part));
            context.SaveChanges();
        }
    }
}
