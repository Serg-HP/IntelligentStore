using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    interface IDiscountSystem
    {
        List<Product> SuggestDiscountedProducts(List<Product> products);
        void SetDiscount(Product product, double DiscountProcent);
        void SetDiscount(ProductType productType, double DiscountProcent);
    }
}
