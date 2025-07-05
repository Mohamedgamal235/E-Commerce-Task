import java.time.LocalDateTime;

public class Main {
    public static void main(String[] args) {
        Cheese cheese = new Cheese("Cheddar", 5.0, 10, LocalDateTime.now().plusDays(5), 1.0);
        TV tv = new TV("Samsung TV", 500.0, 5, 10.0);
        MobileScratchCard scratchCard = new MobileScratchCard("Mobile Recharge", 10.0, 20);
        Customer customer = new Customer("Ali", 10000.0);

        try {
            customer.getCart().addProduct(cheese, 2);
            customer.getCart().addProduct(tv, 3);
            customer.getCart().addProduct(scratchCard, 1);

            CheckoutService.checkout(customer);
        } catch (Exception e) {
            System.out.println("Error is : " + e.getMessage());
        }
    }
} 