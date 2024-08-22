using Northwind.Application.Abstractions;
using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Repositories
{
    internal class SupplierRepository : ISupplierRepository
    {
        private readonly NorthwindDBcontext northwindD;

        public SupplierRepository(NorthwindDBcontext northwindD)
        {
            this.northwindD = northwindD;
        }
        public void Add(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supplier> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
