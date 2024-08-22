using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Abstractions
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();

        void Add(Category category);


    }
}
