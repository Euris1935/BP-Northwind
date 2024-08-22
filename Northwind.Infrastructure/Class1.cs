using Microsoft.EntityFrameworkCore;
using Northwind.Application;
using Northwind.Domain;

namespace Northwind.Infrastructure
{
    public class NorthwindDBcontext : DbContext, INorthwindDBcontext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public NorthwindDBcontext(DbContextOptions<NorthwindDBcontext> options) : base(options)
        {

        }
    }
}
