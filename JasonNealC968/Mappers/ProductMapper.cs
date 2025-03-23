using JasonNealC968.DAL;
using JasonNealC968.Models;
using System.ComponentModel;

namespace JasonNealC968.Mappers
{
    public static class ProductMapper
    {
        public static ProductEntity HydrateProductEntity(ProductEntity productEntity, Product product)
        {
            productEntity.Name = product.Name;
            productEntity.Price = product.Price;
            productEntity.InStock = product.InStock;
            productEntity.Min = product.Min;
            productEntity.Max = product.Max;

            return productEntity;
        }

        public static BindingList<Product> ToProductModels(BindingList<ProductEntity> productEntities)
        {
            var products = new BindingList<Product>();

            foreach (var product in productEntities)
                products.Add(ToProductModel(product));

            return products;
        }

        public static Product ToProductModel(ProductEntity productEntity)
        {
            return new Product()
            {
                ProductID = productEntity.ProductID,
                Name = productEntity.Name,
                InStock = productEntity.InStock,
                Price = productEntity.Price,
                Min = productEntity.Min,
                Max = productEntity.Max,
            };
        }
    }
}
