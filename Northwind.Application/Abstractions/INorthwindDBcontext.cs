using Microsoft.EntityFrameworkCore;
using Northwind.Domain;

namespace Northwind.Application
{
    public interface INorthwindDBcontext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Product { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
    }
}