namespace dotnet_dbcontext.Models{
    public class Cart{
        public Guid Id {get; set;}
        public ICollection<Product> Products {get; set;} = null!;
        public decimal Total {get; set;}
    }
}