using FluentValidation;
using Northwind.UI.UserForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Validators
{
    public class CategoriesfromviewmodelsValidator : AbstractValidator<Categoriesfromviewmodels>
    {
        public CategoriesfromviewmodelsValidator()
        {
            RuleFor(a => a.CategoryId).NotEmpty();
            RuleFor(a => a.CategoryName).NotEmpty();
        }
    }
}
