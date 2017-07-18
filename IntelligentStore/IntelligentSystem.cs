using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class IntelligentSystem
    {
        public Dictionary<Professions, List<ProductType>> CreateAccordance()
        {
            Dictionary<Professions, List<ProductType>> accordance = new Dictionary<Professions, List<ProductType>>();
            accordance.Add(Professions.Builder, new List<ProductType> { ProductType.BuildMaterials,ProductType.Clothes });
            accordance.Add(Professions.HouseWife, new List<ProductType> { ProductType.HomeTools,ProductType.Food,ProductType.Clothes });
            accordance.Add(Professions.Sportsman, new List<ProductType> { ProductType.SportTools,ProductType.Clothes});
            accordance.Add(Professions.Cook, new List<ProductType> { ProductType.Food, ProductType.Food });
            return accordance;
        }

        public void SuggestProducts(Buyer buyer, Store store)
        {
            Console.WriteLine("{0} {1} with cache {2}$ can buy:", buyer.FirstName, buyer.SecondName, buyer.Cash);
            List<ProductType> potentialproducts = CreateAccordance()[buyer.Profession];
            foreach(Product product in store.assortment)
            {
                if (potentialproducts.Contains(product.Type) && buyer.Cash >= product.Price)
                {
                    //product.Show();
                    Console.WriteLine("{0} - {1} (for {2}$ each)", product.Name, buyer.Cash / product.Price, product.Price);
                }
            }
        }



        

    }
}
