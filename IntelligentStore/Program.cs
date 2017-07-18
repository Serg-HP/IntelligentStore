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

        static Store FillStore()
        {
            Store store = new Store();
            store.AddProduct(new Product(1, ProductType.SportTools, "Ball", 10));
            store.AddProduct(new Product(2, ProductType.Food, "Bananas", 20));
            store.AddProduct(new Product(3, ProductType.BuildMaterials, "Bricks", 100));
            store.AddProduct(new Product(4, ProductType.HomeTools, "Oven", 1000));
            store.AddProduct(new Product(5, ProductType.Clothes, "T-shirt", 80));
            return store;
        }
        static void Main(string[] args)
        {
            IntelligentSystem intelligentSystem = new IntelligentSystem();
            Store store = FillStore();
            List<Buyer> buyers = CreateBuyers();
            foreach (Buyer buyer in buyers)
                intelligentSystem.SuggestProducts(buyer, store);
            Console.ReadKey();
        }
    }
}
