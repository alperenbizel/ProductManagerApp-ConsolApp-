
using ProductManagement.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Models.Concreate
{
    public class GroceryProduct : Base
    {
        public bool Fresh { get; set; }

      
        public GroceryProduct(string name, decimal price,bool fresh)
            : base(name, price)
        {
            Fresh = fresh;
        }

    }

}
