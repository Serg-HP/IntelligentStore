using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class Product
    {
        public int Id { get; set; }
        public ProductType Type { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(int id, ProductType type, string name, int price)
        {
            Id = id;
            Type = type;
            Name = name;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine("{0} - {1}$",Name, Price);
        }

    }
}
