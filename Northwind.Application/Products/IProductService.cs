using Northwind.Domain;

namespace Northwind.Application.Products
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

        void CreateProduct(Product product);
        

    }
}