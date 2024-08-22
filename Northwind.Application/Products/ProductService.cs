using FluentValidation;
using Northwind.Application.Abstractions;
using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Products
{
    public partial class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IValidator<Product> validator;

        public ProductService(IProductRepository productRepository, IValidator<Product> validator)
        {
            this.productRepository = productRepository;
            this.validator = validator;
        }

        public void CreateProduct(Product product)
        {
            
            var validatonResult = validator.Validate(product);

            if (!validatonResult.IsValid) 
            {
                throw new ValidationException(validatonResult.Errors);
            
            }
            productRepository.Add(product);


        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }




    }
}
