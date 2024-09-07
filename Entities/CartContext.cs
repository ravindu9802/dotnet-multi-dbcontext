using dotnet_dbcontext.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_dbcontext.Entities;

public class CartContext : DbContext
{
    public CartContext(DbContextOptions<CartContext> options)
        : base(options) { }

    public DbSet<Cart> Carts { get; set; }
    public DbSet<Product> Products { get; set; }

    // assumption: one product can be
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("cart");

        modelBuilder.Entity<Cart>().HasMany(o => o.Products).WithOne().HasForeignKey(p => p.CartId);
        modelBuilder.Entity<Product>().HasData(SeedProducts);
    }

    public static readonly Product[] SeedProducts = 
    {
        new(){Id=Guid.NewGuid(), Name="Product 1", Price=2.3m},
        new(){Id=Guid.NewGuid(), Name="Product 2", Price=4.77m},
        new(){Id=Guid.NewGuid(), Name="Product 3", Price=1.4m},
        new(){Id=Guid.NewGuid(), Name="Product 4", Price=5.0m},
        new(){Id=Guid.NewGuid(), Name="Product 5", Price=8.5m},
        new(){Id=Guid.NewGuid(), Name="Product 6", Price=11.7m},
        new(){Id=Guid.NewGuid(), Name="Product 7", Price=23.22m},
        new(){Id=Guid.NewGuid(), Name="Product 8", Price=18.0m},
        new(){Id=Guid.NewGuid(), Name="Product 9", Price=13.9m},
        new(){Id=Guid.NewGuid(), Name="Product 10", Price=8.6m},
    };
}
