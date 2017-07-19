using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class DiscountSystem:IDiscountSystem
    {
        private Dictionary<Product, double> DiscountedProducts = new Dictionary<Product, double>();
        private Dictionary<ProductType, double> DiscountedTypeProducts = new Dictionary<ProductType, double>();

        public void SetDiscount(Product product, double discountProcent)
        {
            if (discountProcent > 0 && discountProcent < 100)
                DiscountedProducts.Add(product, discountProcent);
        }

        public void SetDiscount(ProductType productType, double discountProcent)
        {
            if (discountProcent > 0 && discountProcent < 100)
                DiscountedTypeProducts.Add(productType, discountProcent);
        }

        public List<Product> SuggestDiscountedProducts(List<Product> products)
        {
            List<Product> suggestedDiscountedProducts = new List<Product>();
            foreach(Product product in products)
            {
                double productDiscount = 0;
                double typeDiscount = 0;
                if (!DiscountedProducts.TryGetValue(product, out productDiscount) && !DiscountedTypeProducts.TryGetValue(product.Type, out typeDiscount))
                    suggestedDiscountedProducts.Add(new Product(product.Id, product.Type, product.Name, product.Price));

                else
                {

                    if (productDiscount > typeDiscount)
                        suggestedDiscountedProducts.Add(new DiscountedProduct(product.Id, product.Type, product.Name, product.Price, productDiscount));
                    else
                        suggestedDiscountedProducts.Add(new DiscountedProduct(product.Id, product.Type, product.Name, product.Price, typeDiscount));
                } 
                
                

            }
            return suggestedDiscountedProducts;
        }
    }
}
