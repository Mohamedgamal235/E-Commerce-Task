using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce
{
    class Cart
    {
        private Dictionary<Product, int> items = new Dictionary<Product, int>();
        
        public void AddProduct(Product p , int quantity) 
        {
            if (items.ContainsKey(p))
                items[p] += quantity;
            else
                items.Add(p, quantity);
        }

        public bool IsEmpty()
        {
            return items.Count() == 0; 
        }

        public Dictionary<Product , int> GetItem()
        {
            return items; 
        }

        public void Clear()
        {
            items.Clear();
        }

    }
}
