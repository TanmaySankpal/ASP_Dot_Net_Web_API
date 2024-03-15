using Microsoft.EntityFrameworkCore;

namespace Order_Service_Web_API.Models
{
    public class OrdContext:DbContext
    {
        public OrdContext(DbContextOptions options):base(options)
        {
                
        }
        DbSet<Order>Order
        {
            get;
            set;
        }
    }
}
