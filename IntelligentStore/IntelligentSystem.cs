using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class IntelligentSystem:IIntelligentSystem
    {
        private Dictionary<Professions, List<ProductType>> accordance;
        public IntelligentSystem()
        {
            accordance = CreateAccordance();
        }
        public Dictionary<Professions, List<ProductType>> CreateAccordance()
        {
            Dictionary<Professions, List<ProductType>> accordance = new Dictionary<Professions, List<ProductType>>();
            accordance.Add(Professions.Builder, new List<ProductType> { ProductType.BuildMaterials,ProductType.Clothes });
            accordance.Add(Professions.HouseWife, new List<ProductType> { ProductType.HomeTools,ProductType.Food,ProductType.Clothes });
            accordance.Add(Professions.Sportsman, new List<ProductType> { ProductType.SportTools,ProductType.Clothes});
            accordance.Add(Professions.Cook, new List<ProductType> { ProductType.Food, ProductType.Food });
            return accordance;
        }

        public List<Product> SuggestProducts(Buyer buyer, List<Product> products)
        {
            List<Product> CanToBuy = new List<Product>();
            List<ProductType> potentialproducts = accordance[buyer.Profession];
            foreach(Product product in products)
            {
                if (potentialproducts.Contains(product.Type) && buyer.Cash >= product.Price)
                {
                    CanToBuy.Add(product);
                }
            }
            return CanToBuy;
        }



        

    }
}
