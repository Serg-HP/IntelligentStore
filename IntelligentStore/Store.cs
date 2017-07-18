using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class Store
    {
        public List<Product> assortment;
        public Store()
        {
            assortment = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            assortment.Add(product);
        }
    }
}
