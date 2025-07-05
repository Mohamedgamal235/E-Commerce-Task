import java.util.ArrayList;
import java.util.List;
import java.util.Map;

public class CheckoutService {
    public static void checkout(Customer customer) throws Exception {
        Cart cart = customer.getCart();

        if (cart.isEmpty()) {
            throw new Exception("Cart is Empty");
        }

        double subtotal = 0;
        double shippingFees = 0;

        List<IShippable> shippableItems = new ArrayList<>();

        for (Map.Entry<Product, Integer> entry : cart.getItems().entrySet()) {
            Product product = entry.getKey();
            int quantity = entry.getValue();

            if (quantity > product.getQuantity()) {
                throw new Exception("Product : " + product.getName() + " is out of stock.");
            }

            if (product instanceof IExpirable) {
                IExpirable expire = (IExpirable) product;
                if (expire.isExpired()) {
                    throw new Exception("Product : " + product.getName() + " is Expired.");
                }
            }

            subtotal += (product.getPrice() * product.getQuantity());

            if (product instanceof IShippable) {
                IShippable shippable = (IShippable) product;
                shippableItems.add(shippable);
                shippingFees += shippable.getWeight() * 1.5;
            }
        }

        double total = subtotal + shippingFees;

        if (total > customer.getBalance()) {
            throw new Exception("Insufficient balance.");
        }

        for (Map.Entry<Product, Integer> entry : cart.getItems().entrySet()) {
            entry.getKey().reduceQuantity(entry.getValue());
        }

        customer.reduceBalance(total);

        System.out.println("\n=== Checkout Summary ===");
        System.out.println("Subtotal: $" + subtotal);
        System.out.println("Shipping Fees: $" + shippingFees);
        System.out.println("Total Paid: $" + total);
        System.out.println("Remaining Balance: $" + customer.getBalance());

        if (shippableItems.size() > 0) {
            ShippingService shippingService = new ShippingService();
            shippingService.shippingItems(shippableItems);
        }

        cart.clear();
    }
} 