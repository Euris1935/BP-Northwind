using FluentValidation;
using Northwind.UI.UserForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Validators
{
    public class ProductsfromviewmodelsValidator : AbstractValidator<Productsfromviewmodels>
    {
        public ProductsfromviewmodelsValidator()
        {
           // RuleFor(a => a.ProductId).NotEmpty();
            RuleFor(a => a.ProductName).NotEmpty().MaximumLength(40);
            RuleFor(a => a.UnitPrice).NotEqual(0);
        }
    }
}
