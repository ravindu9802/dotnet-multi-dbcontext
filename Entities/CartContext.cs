using dotnet_dbcontext.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_dbcontext.Entities;

public class CartContext : DbContext
{
    public CartContext(DbContextOptions<CartContext> dbContext)
        : base() { }

    public DbSet<Cart> Carts { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>().HasMany(o => o.Products).WithOne().HasForeignKey(p => p.CartId);
    }
}
