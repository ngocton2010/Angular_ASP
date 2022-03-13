using Microsoft.EntityFrameworkCore;


namespace ASPWebAngular.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }    
    }
}
