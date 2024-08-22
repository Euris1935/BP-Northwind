using FluentValidation;
using Northwind.Domain;

namespace Northwind.Application.Products
{
    public partial class ProductService
    {
        public class ProductValidator : AbstractValidator<Product> 
        {
            public ProductValidator()
            {
                RuleFor(a => a.ProductName).NotEmpty().MaximumLength(40);
                RuleFor(a => a.Discontinued).NotEmpty();
                
            }





        }




    }
}
