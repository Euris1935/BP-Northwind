using Northwind.Application.Abstractions;
using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Repositories
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly NorthwindDBcontext northwindD;

        public CategoryRepository(NorthwindDBcontext northwindD)
        {
            this.northwindD = northwindD;
        }
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
