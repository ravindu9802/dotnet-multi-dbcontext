namespace dotnet_dbcontext.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
