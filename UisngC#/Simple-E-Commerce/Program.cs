using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cheese cheese = new Cheese("Cheddar", 5.0, 10, DateTime.Now.AddDays(5), 1.0);
            TV tv = new TV("Samsung TV", 500.0, 5, 10.0);
            MobileScratchCard scratchCard = new MobileScratchCard("Mobile Recharge", 10.0, 20);
            Customer customer = new Customer("Ali", 10000.0);

            try
            {
                customer.Cart.AddProduct(cheese, 2);
                customer.Cart.AddProduct(tv, 3);
                customer.Cart.AddProduct(scratchCard, 1);

                CheckoutService.Checkout(customer);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error is : {e.Message}");
            }

        }

        

        


    }
}
