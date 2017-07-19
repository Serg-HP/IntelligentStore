using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class IntelligentStoreWithDiscount:IntelligentStore
    {
        public IDiscountSystem DiscountSystem { get; }
        public IntelligentStoreWithDiscount(List<Product> products, IIntelligentSystem intelligentSystem, IDiscountSystem discountSystem) : base(products, intelligentSystem)
        {
            DiscountSystem = discountSystem;
        }
    }
}
