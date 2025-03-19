using JasonNealC968.Models;
using Microsoft.EntityFrameworkCore;

namespace JasonNealC968.DAL;

public class InventoryContext : DbContext
{
    public DbSet<Part> Parts { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Database=InventoryManagementSystem;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Part>().HasData(
            new Part { PartID = 1, Name = "Wheel", Inventory = 15, Price = 12.11m, Min = 5, Max = 25 },
            new Part { PartID = 2, Name = "Pedal", Inventory = 11, Price = 8.22m, Min = 5, Max = 25 },
            new Part { PartID = 3, Name = "Chain", Inventory = 12, Price = 8.33m, Min = 5, Max = 25 },
            new Part { PartID = 4, Name = "Seat", Inventory = 8, Price = 4.55m, Min = 2, Max = 15 });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductID = 1, Name = "Red Bicycle", Inventory = 15, Price = 11.44m, Min = 1, Max = 25 },
            new Product { ProductID = 2, Name = "Yellow Bicycle", Inventory = 19, Price = 9.66m, Min = 1, Max = 20 },
            new Product { ProductID = 3, Name = "Blue Bicycle", Inventory = 5, Price = 12.77m, Min = 1, Max = 25 });
    }
}
