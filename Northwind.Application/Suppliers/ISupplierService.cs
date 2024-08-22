using Northwind.Domain;

namespace Northwind.Application.Suppliers
{
    internal interface ISupplierService
    {
        IEnumerable<Supplier> GetSuppliers();

        void CreateSupplier(Supplier supplier);
    }
}