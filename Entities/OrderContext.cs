using dotnet_dbcontext.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_dbcontext.Entities;

public class OrderContext : DbContext
{
    public OrderContext(DbContextOptions<OrderContext> context)
        : base() { }

    public DbSet<Order> Orders {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
