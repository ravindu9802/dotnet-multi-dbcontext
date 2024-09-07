namespace dotnet_dbcontext.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public ICollection<Product> Products { get; set; } = null!;
    }
}
