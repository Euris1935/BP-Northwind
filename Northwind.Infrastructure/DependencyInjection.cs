using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application;
using Northwind.Application.Abstractions;
using Northwind.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure
{
    public static class DependencyInjection
    {
        public static ServiceCollection AddInfrastructure(this ServiceCollection services)
        {
            services.AddScoped<INorthwindDBcontext>(a=> a.GetRequiredService<NorthwindDBcontext>());
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddDbContext<NorthwindDBcontext>(options => {
                options.UseSqlServer();
                });

            return services;

        }

    }
}
