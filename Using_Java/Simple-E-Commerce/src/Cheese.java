import java.time.LocalDateTime;

public class Cheese extends Product implements IShippable, IExpirable {
    private LocalDateTime expireTime;
    private double weight;

    public Cheese(String name, double price, int quantity, LocalDateTime expireTime, double weight) {
        super(name, price, quantity);
        this.expireTime = expireTime;
        this.weight = weight;
    }

    @Override
    public String getName() {
        return super.getName();
    }

    @Override
    public double getWeight() {
        return weight;
    }

    @Override
    public boolean isExpired() {
        return LocalDateTime.now().isAfter(expireTime);
    }
} 