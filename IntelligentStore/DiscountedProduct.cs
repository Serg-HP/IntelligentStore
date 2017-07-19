using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class DiscountedProduct:Product
    {
        public double DiscountProcent { get { return 100 - Discount*100; } }
        private double Discount { get; } = 1;
        public DiscountedProduct(int id, ProductType productType, string name, double price, double discountProcent):base(id, productType, name, price)
        {
            if (discountProcent > 0 && discountProcent < 100)
            {
                Discount = 1.0 - discountProcent / 100.0;
                this.Price *= Discount;
            }
        }
    }
}
