import java.util.List;

public class ShippingService {
    public void shippingItems(List<IShippable> list) {
        System.out.println("\nShipping the following items:");
        for (IShippable item : list) {
            System.out.println("- " + item.getName() + ", Weight: " + item.getWeight() + " kg");
        }
    }
} 