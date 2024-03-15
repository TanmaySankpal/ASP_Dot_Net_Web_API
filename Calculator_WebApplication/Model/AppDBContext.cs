using Microsoft.EntityFrameworkCore;

namespace Calculator_WebApplication.Model
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<NumberSet> NumberSets
        {
            get;
            set;
        }
    }
}
