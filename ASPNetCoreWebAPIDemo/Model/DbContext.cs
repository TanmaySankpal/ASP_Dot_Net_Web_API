using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreWebAPIDemo.Model
{
    

    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Employee> Employee 
        { 
            get; 
            set; 
        }
    }
}
