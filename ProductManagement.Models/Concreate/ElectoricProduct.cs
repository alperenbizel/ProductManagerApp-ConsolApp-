using ProductManagement.Models.Abstract;
using System;

namespace ProductManagement.Models.Concreate
{
    public  class ElectronicProduct : Base
    {
        public int WarrantyInMonths { get; set; }

        // Yapılandırıcı
        public ElectronicProduct(string name, decimal price, int warrantyInMonths)
            : base(name, price)
        {
            WarrantyInMonths = warrantyInMonths;
        }
       
    }
}
