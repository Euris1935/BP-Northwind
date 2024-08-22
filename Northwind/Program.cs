using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application;
using Northwind.Application.Abstractions;
using Northwind.Application.Products;
using Northwind.Domain;
using Northwind.Infrastructure;
using Northwind.Infrastructure.Data;
using Northwind.Infrastructure.Repositories;
using Northwind.UI.UserControls;
using Northwind.UI.UserForms;
using System.Configuration;

namespace Northwind
{
    public static class Program
    {
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {


            IConfiguration configuration = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json")
                 .Build();

            var services = new ServiceCollection();

            // Configuración de DbContext
            services.AddDbContext<NorthwindDBcontext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("NorthwindConnectionString")));

            // Registro de servicios
            services.AddInfrastructure();
            services.AddApplication();
            services.AddSingleton(configuration);
            
            services.AddScoped<CreateProducts>();
            services.AddScoped<CreateCategorys>();
            services.AddScoped<CreateSuppliers>();
            services.AddScoped<ProductDataProvider>();
            services.AddScoped<SupplierDataProvider>();
            services.AddScoped<CategoryDataProvider>();
            services.AddScoped<ProductsUserControl>();
            services.AddScoped<CategoryUserControl>();
            services.AddScoped<SuppliersUserControl>();
            services.AddScoped<Productsfromviewmodels>();
            services.AddScoped<Categoriesfromviewmodels>();
            services.AddScoped<Suppliersfromviewmodels>();
            services.AddScoped<IProductDataProvider, ProductDataProvider>();
            services.AddScoped<ICategoryDataProvider, CategoryDataProvider>();
            services.AddScoped<ISupplierDataProvider, SupplierDataProvider>();
            services.AddValidatorsFromAssemblyContaining<MainForm>();
            services.AddScoped<MainForm>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddValidatorsFromAssemblyContaining<MainForm>();
    
            var serviceProvider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Reemplaza Application.Run por System.Windows.Forms.Application.Run
            System.Windows.Forms.Application.Run(serviceProvider.GetService<MainForm>());

            


        }
    }
}