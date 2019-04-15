using Ecom.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace Ecom.Data.ContextFactory
{
    public class DbContextFactory : IDesignTimeDbContextFactory<EcomDbContext>
    {
        public EcomDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EcomDbContext>();
            var connection = @"Data Source=(LOCALDB)\MSSQLLocalDB;Initial Catalog=ecommercedb;Integrated Security=True;Pooling=False";
            builder.UseSqlServer(connection,
                builderOption => builderOption.MigrationsAssembly(typeof(EcomDbContext).GetTypeInfo().Assembly.GetName().Name));

            return new EcomDbContext(builder.Options);
        }
    }
}
