using JasonNealC968.Constants;
using JasonNealC968.DAL;
using JasonNealC968.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Mappers
{
    public static class ProductMapper
    {
        public static ProductEntity ToProductEntity(Product product)
        {
            return new ProductEntity()
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Price = product.Price,
                InStock = product.InStock,
                Min = product.Min,
                Max = product.Max,
            };
        }

        public static BindingList<Product> ToProductModels(BindingList<ProductEntity> productEntities)
        {
            var products = new BindingList<Product>();

            foreach (var product in productEntities)
            {
                products.Add(ToProductModel(product));
            }

            return products;
        }

        public static Product ToProductModel(ProductEntity productEntity)
        {
            return new Product()
            {
                Name = productEntity.Name,
                InStock = productEntity.InStock,
                Price = productEntity.Price,
                Min = productEntity.Min,
                Max = productEntity.Max,
            };
        }
    }
}
