using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class Program
    {
        static List<Buyer> CreateBuyers()
        {
            List<Buyer> buyers = new List<Buyer>();
            buyers.Add(new Buyer(1,"Mary", "Smith", new DateTime(1995, 12, 1), Professions.HouseWife, 100));
            buyers.Add(new Buyer(2, "Peter", "Collins", new DateTime(1990, 3, 2), Professions.Builder, 500));
            buyers.Add(new Buyer(3, "Mike", "White", new DateTime(1999, 4, 10), Professions.Sportsman, 2000));
            buyers.Add(new Buyer(4, "Kate", "Black", new DateTime(1993, 8, 23), Professions.Cook, 400));
            return buyers;
        }

        static List<Product> FillStore()
        {
            List<Product> assortment = new List<Product>();
            assortment.Add(new Product(1, ProductType.SportTools, "Ball", 10));
            assortment.Add(new Product(2, ProductType.Food, "Bananas", 20));
            assortment.Add(new Product(3, ProductType.BuildMaterials, "Bricks", 100));
            assortment.Add(new Product(4, ProductType.HomeTools, "Oven", 1000));
            assortment.Add(new Product(5, ProductType.Clothes, "T-shirt", 80));
            return assortment;
        }

        static void SetDiscounts(IntelligentStoreWithDiscount store)
        {
            store.DiscountSystem.SetDiscount(ProductType.Food, 50);
            store.DiscountSystem.SetDiscount(store.Assortment[0], 20);
        }

        static void ShowSuggestedProductsWithoutDiscount(IntelligentStore store, List<Buyer> buyers)
        {
            foreach (Buyer buyer in buyers)
            {
                Console.WriteLine("{0} with {1} can buy:", buyer.FirstName, buyer.Cash);
                List<Product> suggestedProducts = store.IntelligentSystem.SuggestProducts(buyer, store.Assortment);
                foreach (Product product in suggestedProducts)
                    Console.WriteLine("{0} - {1} (for each {2})", product.Name, (int)(buyer.Cash / product.Price), product.Price);
            }
                
        }

        static void ShowSuggestedProductsWithDiscount(IntelligentStoreWithDiscount store, List<Buyer> buyers)
        {
            foreach (Buyer buyer in buyers)
            {
                Console.WriteLine("{0} with {1}$ can buy:", buyer.FirstName, buyer.Cash);
                List<Product> suggestedProducts = store.IntelligentSystem.SuggestProducts(buyer, store.DiscountSystem.SuggestDiscountedProducts(store.Assortment));
                foreach (Product product in suggestedProducts)
                {
                    DiscountedProduct discountedProduct = product as DiscountedProduct;
                    if (discountedProduct!=null)
                        Console.WriteLine("{0} - {1} (for each {2}$ with discount {3}%)", discountedProduct.Name, (int)(buyer.Cash / discountedProduct.Price), discountedProduct.Price, discountedProduct.DiscountProcent);
                    else
                        Console.WriteLine("{0} - {1} (for each {2}$)", product.Name, (int)(buyer.Cash / product.Price), product.Price);
                }
            }

        }
        static void Main(string[] args)
        {
            List<Product> products = FillStore();
            List<Buyer> buyers = CreateBuyers();
            IntelligentStoreWithDiscount intelligentStore = new IntelligentStoreWithDiscount(products, new IntelligentSystem(), new DiscountSystem());
            ShowSuggestedProductsWithoutDiscount(intelligentStore, buyers);
            Console.WriteLine();
            SetDiscounts(intelligentStore);
            ShowSuggestedProductsWithDiscount(intelligentStore, buyers);
            Console.ReadKey();
        }
    }
}
