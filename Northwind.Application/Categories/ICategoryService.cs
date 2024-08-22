using Northwind.Domain;

namespace Northwind.Application.Categories
{
    internal interface ICategoryService
    {
        IEnumerable<Category> GetSuppliers();

        void CreateCategory(Category category);
    }
}