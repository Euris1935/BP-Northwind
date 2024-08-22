using Northwind.Domain.Models;

namespace Northwind.Infrastructure.Data
{
    public interface ISupplierDataProvider
    {
        void Createsupplier(Supplier supplier);
        void DeleteProduct(int productId);
        Supplier GetSupplierById(int id);
        List<Supplier> GetSuppliers();
        void UpdateSuppliers(Supplier supplier);
    }
}