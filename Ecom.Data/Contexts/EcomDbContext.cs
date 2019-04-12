using Ecom.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Data.Contexts
{
    public class EcomDbContext : DbContext
    {
        public EcomDbContext(DbContextOptions<EcomDbContext> builder) : 
            base(builder) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
           var connection = @"Data Source=(LOCALDB)\MSSQLLocalDB;Initial Catalog=ecommercedb;Integrated Security=True;Pooling=False";
           builder.UseSqlServer(connection);
        }
    }
}
