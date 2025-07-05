using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce
{
    class ShippingService
    {
        public void ShippingItems(List<IShippable> list)
        {
            Console.WriteLine("\nShipping the following items:");
            foreach (var item in list)
                Console.WriteLine($"- {item.GetName()}, Weight: {item.GetWeight()} kg");
        }
    }
}
