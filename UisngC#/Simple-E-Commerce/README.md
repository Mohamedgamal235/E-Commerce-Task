# Simple E-Commerce - Java Version

This is a Java conversion of the original C# Simple E-Commerce application. All logic has been preserved during the conversion.

## Project Structure

```
src/
├── Main.java                    # Main entry point (equivalent to Program.cs)
├── Product.java                 # Base product class
├── IExpirable.java             # Interface for expirable products
├── IShippable.java             # Interface for shippable products
├── Cheese.java                 # Cheese product (implements both interfaces)
├── TV.java                     # TV product (implements IShippable)
├── MobileScratchCard.java      # Mobile scratch card product
├── Customer.java               # Customer class with cart
├── Cart.java                   # Shopping cart implementation
├── CheckoutService.java        # Checkout logic
└── ShippingService.java        # Shipping service
```

## How to Run

### Option 1: Using the build script (Windows)
```bash
build.bat
```

### Option 2: Manual compilation
```bash
# Create bin directory
mkdir bin

# Compile all Java files
javac -d bin src/*.java

# Run the program
java -cp bin Main
```

## Key Changes from C# to Java

1. **File Structure**: Each class is in its own `.java` file
2. **Naming Conventions**: Methods follow Java camelCase convention
3. **Collections**: `Dictionary` → `HashMap`, `List` → `ArrayList`
4. **DateTime**: `DateTime` → `LocalDateTime`
5. **Properties**: C# properties → Java getter methods
6. **Exception Handling**: Same logic, Java syntax
7. **Console Output**: `Console.WriteLine` → `System.out.println`

## Features

- Product management with different types (Cheese, TV, Mobile Scratch Card)
- Shopping cart functionality
- Expiration checking for perishable items
- Shipping calculation for physical items
- Checkout process with balance validation
- Exception handling for various scenarios

The application demonstrates object-oriented programming concepts including inheritance, interfaces, and polymorphism. 