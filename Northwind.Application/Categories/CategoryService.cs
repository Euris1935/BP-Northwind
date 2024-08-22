using FluentValidation;
using Northwind.Application.Abstractions;
using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Northwind.Application.Products.ProductService;

namespace Northwind.Application.Categories
{
    internal partial class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IValidator<Category> validator;

        public CategoryService(ICategoryRepository categoryRepository, IValidator<Category> validator)
        {
            this.categoryRepository = categoryRepository;
            this.validator = validator;
        }

        public void CreateCategory(Category category)
        {
            
            var validatonResult = validator.Validate(category);

            if (!validatonResult.IsValid)
            {
                throw new ValidationException(validatonResult.Errors);

            }

            categoryRepository.Add(category);
        }


        public IEnumerable<Category> GetSuppliers()
        {
            return categoryRepository.GetAll();

        }

    }
}
