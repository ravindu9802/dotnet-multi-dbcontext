using Microsoft.EntityFrameworkCore;

namespace dotnet_dbcontext.Models{
    public class Cart{
        public Guid Id {get; set;}
        
        public ICollection<Product>? Products {get; set;}

        [Precision(10,2)]
        public decimal Total {get; set;}
    }
}