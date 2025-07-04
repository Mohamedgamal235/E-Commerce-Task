using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce
{
    internal interface CheckoutService
    {
        public static void Checkout(Customer customer)
        {
            var cart = customer.Cart;

            if (cart.IsEmpty())
                throw new Exception("Cart is Empty");

            double subtotal = 0;
            double shippingFees = 0;

            List<IShippable> shippableItems = new List<IShippable>();

            foreach(var e in cart.GetItem())
            {
                Product product = e.Key;
                int quantity = e.Value;

                if (quantity > product.Quantity)
                    throw new Exception($"Product : {product.Name} is out of stock.");

                if (product is IExpirable expire && expire.IsExpired())
                    throw new Exception($"Product : {product.Name} is Expired.");

                subtotal += (product.Price * product.Quantity);


                if (product is IShippable ishippable)
                {
                    shippableItems.Add(ishippable);
                    shippingFees += ishippable.GetWeight() * 1.5 ; 
                }

            }

            double total = subtotal + shippingFees;

            if (total > customer.Balance)
                throw new Exception("Insufficient balance.");

            foreach (var e in cart.GetItem())
                e.Key.ReduceQuantity(e.Value);

            customer.ReduceBalance(total);

            Console.WriteLine("\n=== Checkout Summary ===");
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Shipping Fees: ${shippingFees}");
            Console.WriteLine($"Total Paid: ${total}");
            Console.WriteLine($"Remaining Balance: ${customer.Balance}");

            if (shippableItems.Count > 0)
            {
                ShippingService shippingService = new();
                shippingService.ShippingItems(shippableItems);
            }

            cart.Clear(); 
        }
    }
}
