using System;

namespace ProductManagement.Models.Abstract
{
    public class Base
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Yapılandırıcı ekleyin
        public Base(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
  
    }
}
