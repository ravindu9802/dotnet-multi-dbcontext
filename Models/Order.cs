namespace dotnet_dbcontext.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public ICollection<Guid>? Products { get; set; }
    }
}
