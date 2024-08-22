using FluentValidation;
using Northwind.Domain;

namespace Northwind.Application.Categories
{
    internal partial class CategoryService
    {
        public class CategoryValidator : AbstractValidator<Category> 
        {
            public CategoryValidator()
            {
                RuleFor(a => a.CategoryName).NotEmpty();
                
            }

        }

    }
}
