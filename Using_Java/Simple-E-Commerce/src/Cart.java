import java.util.HashMap;
import java.util.Map;

public class Cart {
    private Map<Product, Integer> items = new HashMap<>();
    
    public void addProduct(Product p, int quantity) {
        if (items.containsKey(p)) {
            items.put(p, items.get(p) + quantity);
        } else {
            items.put(p, quantity);
        }
    }

    public boolean isEmpty() {
        return items.isEmpty();
    }

    public Map<Product, Integer> getItems() {
        return items;
    }

    public void clear() {
        items.clear();
    }
} 