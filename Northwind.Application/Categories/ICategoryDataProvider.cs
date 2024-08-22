using Northwind.Domain.Models;

namespace Northwind.Infrastructure.Data
{
    public interface ICategoryDataProvider
    {
        void CrateCategories(Category category);
        void DeleteProduct(int productId);
        List<Category> GetCategories();
        Category GetCategoryById(int id);
        void UpdateCategories(Category category);
    }
}