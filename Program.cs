using dotnet_dbcontext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CartContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("database"),
        // update migration history table details 
        o => o.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "cart")
    );
});
builder.Services.AddDbContext<OrderContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("database"),
        // update migration history table details 
        o => o.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "order")
    );
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
