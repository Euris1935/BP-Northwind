using Northwind.Domain.Models;

namespace Northwind.Infrastructure.Data
{
    public interface IProductDataProvider
    {
        void CraeteProduct(Product product);
        void DeleteProduct(int productId);
        IEnumerable<Category> GetCategories();
        Product GetProductById(int id);
        List<Product> GetProducts();
        IEnumerable<Supplier> GetSuppliers();
        void UpdateProducts(Product product);
    }
}