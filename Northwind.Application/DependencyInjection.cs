using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Categories;
using Northwind.Application.Products;
using Northwind.Application.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        
        }
        
    }
}
