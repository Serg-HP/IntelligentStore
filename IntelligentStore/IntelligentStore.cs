using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class IntelligentStore:Store
    {
        public IIntelligentSystem IntelligentSystem { get; }
        public IntelligentStore(List<Product> products, IIntelligentSystem intelligentSystem):base(products)
        {
            IntelligentSystem = intelligentSystem;
        }
    }
}
