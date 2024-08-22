using FluentValidation;
using Northwind.Domain;

namespace Northwind.Application.Suppliers
{
    public class SupplierValidator : AbstractValidator<Supplier> 
    {
        public SupplierValidator()
        {
            RuleFor(a => a.CompanyName).NotEmpty();
            
            
        }

    }



}
