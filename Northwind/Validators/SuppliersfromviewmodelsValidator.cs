using FluentValidation;
using Northwind.UI.UserForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Validators
{
    public class SuppliersfromviewmodelsValidator : AbstractValidator<Suppliersfromviewmodels>
    {
        public SuppliersfromviewmodelsValidator()
        {
            RuleFor(x => x.SupplierId).NotEmpty();
            RuleFor(x => x.CompanyName).NotEmpty();
            RuleFor(x => x.ContactName).NotEmpty();
            RuleFor(x => x.ContactTitle).NotEmpty();
        }
    }
}
