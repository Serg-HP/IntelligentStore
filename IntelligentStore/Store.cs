using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class Store
    {
        public List<Product> Assortment { get; set; }
        public Store()
        {
            Assortment = new List<Product>();
        }
        public Store(List<Product> products)
        {
            Assortment = products;
        }
        public void AddProduct(Product product)
        {
            Assortment.Add(product);
        }
    }
}
