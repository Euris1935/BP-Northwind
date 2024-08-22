using FluentValidation;
using Northwind.Application.Abstractions;
using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Northwind.Application.Products.ProductService;

namespace Northwind.Application.Suppliers
{
    internal class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository supplierRepository;
        private readonly IValidator<Supplier> validator;

        public SupplierService(ISupplierRepository supplierRepository, IValidator<Supplier> validator)
        {
            this.supplierRepository = supplierRepository;
            this.validator = validator;
        }

        public void CreateSupplier(Supplier supplier)
        {
            
            var validatonResult = validator.Validate(supplier);

            if (!validatonResult.IsValid)
            {
                throw new ValidationException(validatonResult.Errors);

            }
            supplierRepository.Add(supplier);
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return supplierRepository.GetAll();
        }
    }



}
