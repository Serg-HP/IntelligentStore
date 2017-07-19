using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    interface IIntelligentSystem
    {
        List<Product> SuggestProducts(Buyer buyers, List<Product> products);
    }
}
