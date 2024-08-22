using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.UI.UserForms
{
    public class Categoriesfromviewmodels
    {


        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public string? Description { get; set; }
        public string Title { get; internal set; }
    }
}
