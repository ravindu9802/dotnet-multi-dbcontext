using dotnet_dbcontext.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CartContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("database"));
});
builder.Services.AddDbContext<OrderContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("database"));
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
