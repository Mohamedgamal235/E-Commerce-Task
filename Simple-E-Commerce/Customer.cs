using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce
{
    class Customer
    {
        public string Name { get; }
        public double Balance { get; private set; }
        public Cart Cart { get; } = new Cart();

        public Customer(string name , double balance)
        {
            Name = name;
            Balance = balance; 
        }

        public void ReduceBalance(double price)
        {
            Balance -= price;
        }
    }
}
