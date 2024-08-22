using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Abstractions
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetAll();

        void Add(Supplier supplier);



    }
}
