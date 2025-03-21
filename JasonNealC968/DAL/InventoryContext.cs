using JasonNealC968.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.DAL
{
    public class InventoryContext : DbContext
    {
        public DbSet<PartEntity> Parts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Database=InventoryDatabase;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartEntity>().HasData(
                new PartEntity { PartID = 1, Name = "Wheel", InStock = 15, Price = 12.11m, Min = 5, Max = 25, Category = PartCategory.InHouse, MachineID = 123 },
                new PartEntity { PartID = 2, Name = "Pedal", InStock = 11, Price = 8.22m, Min = 5, Max = 25, Category = PartCategory.InHouse, MachineID = 123 },
                new PartEntity { PartID = 3, Name = "Chain", InStock = 12, Price = 8.33m, Min = 5, Max = 25, Category = PartCategory.InHouse, MachineID = 123 },
                new PartEntity { PartID = 4, Name = "Seat", InStock = 8, Price = 4.55m, Min = 2, Max = 15, Category = PartCategory.InHouse, MachineID = 123 });

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { ProductID = 1, Name = "Red Bicycle", InStock = 15, Price = 11.44m, Min = 1, Max = 25 },
                new ProductEntity { ProductID = 2, Name = "Yellow Bicycle", InStock = 19, Price = 9.66m, Min = 1, Max = 20 },
                new ProductEntity { ProductID = 3, Name = "Blue Bicycle", InStock = 5, Price = 12.77m, Min = 1, Max = 25 });
        }
    }
}
