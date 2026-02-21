public interface IProduct
{
    int Id { get; }
    string Name { get; }
    decimal Price { get; }
    Category Category { get; }
}

public enum Category { Electronics, Clothing, Books, Groceries }

// 1. Create a generic repository for products
public class ProductRepository<T> where T : class, IProduct
{
    private List<T> _products = new List<T>();
    
    // TODO: Implement method to add product with validation
    public void AddProduct(T product)
    {
        // Rule: Product ID must be unique
        // Rule: Price must be positive
        // Rule: Name cannot be null or empty
        // Add to collection if validation passes
        if(!_products.Any(p=>p.Id == product.Id) && product.Price>0 && !string.IsNullOrEmpty(product.Name))
        {
            _products.Add(product);
        }
        else
        {
            throw new Exception("product already exists");
        }
    }
    
    // TODO: Create method to find products by predicate
    public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        // Should return filtered products
        return _products.Where(predicate);
    }
    
    // TODO: Calculate total inventory value
    public decimal CalculateTotalValue()
    {
        // Return sum of all product prices
            return _products.Sum(s=>s.Price);
        
    }
}

// 2. Specialized electronic product
public class ElectronicProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category => Category.Electronics;
    public int WarrantyMonths { get; set; }
    public string Brand { get; set; }
}

// 3. Create a discounted product wrapper
public class DiscountedProduct<T> where T : IProduct
{
    private T _product;
    private decimal _discountPercentage;
    
    public DiscountedProduct(T product, decimal discountPercentage)
    {
        // TODO: Initialize with validation
        // Discount must be between 0 and 100
        if (product == null)
        {
            throw new ArgumentException("product is null");
        }
        if(discountPercentage<0 || discountPercentage>100)
        {
            throw new InvalidOperationException("Discount must be between 0 and 100");
        }

            _discountPercentage = discountPercentage;
            _product = product;
    }
    // TODO: Implement calculated price with discount
    public decimal DiscountedPrice => _product.Price * (1 - _discountPercentage / 100);

    // TODO: Override ToString to show discount details
    public override string ToString()
    {
        return $"{_product.name} | original: {_product.Price} | Discount: {_discountPercentage} | finalPrice: {DiscountedPrice}";
    }
}

// 4. Inventory manager with constraints
public class InventoryManager
{
    // TODO: Create method that accepts any IProduct collection
    public void ProcessProducts<T>(IEnumerable<T> products) where T : IProduct
    {
        // a) Print all product names and prices
        // b) Find the most expensive product
        // c) Group products by category
        // d) Apply 10% discount to Electronics over $500
        if(products==null || !products.Any())
        {
            System.Console.WriteLine("No product available");
            return;
        }
            foreach(var p in products)
            {
                System.Console.WriteLine($"{p.Name} : {p.Price}");
            }

        var maxPrice = products.OrderByDescending(p=>p.Price).FirstOrDefault();
        System.Console.WriteLine($"Most Expensive Product: {maxPrice.Name} : {maxPrice.Price}");


        var GroupedProduct = products.GroupBy(c=>c.Category);
        foreach(var grp in GroupedProduct)
        {
            System.Console.WriteLine($"Category:{grp.Key}");
            foreach(var item in grp)
            {
                System.Console.WriteLine($"{item.Name} : {item.Price}");
            }
        }

        var electronic  = products.Where(c=>c.Category == Category.Electronics && c.Price > 500);
        foreach(var item in electronic)
        {
            if(item.GetType()==typeof(ElectronicProduct))
            {
                ElectronicProduct tempObj;
                tempObj=(ElectronicProduct)item;
                tempObj.Price = item.Price*0.9;
            }
            //item.Price = item.Price*0.9;

            var discounted = new DiscountedProduct<T>(item, 10);
            Console.WriteLine(discounted);
        }
    }
    
    // TODO: Implement bulk price update with delegate
    public void UpdatePrices<T>(List<T> products, Func<T, decimal> priceAdjuster) 
        where T : IProduct
    {
        // Apply priceAdjuster to each product
        // Handle exceptions gracefully
        if(products == null || products.Count ==0)
        {
            throw new InvalidOperationException("product list cannot be empty");
        }
        
        foreach(var p in products)
        {
            if (priceAdjuster(p) < 0)
            {
                throw new InvalidOperationException("Price cannot be negative");
            }
            p.Price = priceAdjuster(p);
            
        }

    }
}

// 5. TEST SCENARIO: Your tasks:
// a) Implement all TODO methods with proper error handling
// b) Create a sample inventory with at least 5 products
// c) Demonstrate:
//    - Adding products with validation
//    - Finding products by brand (for electronics)
//    - Applying discounts
//    - Calculating total value before/after discount
//    - Handling a mixed collection of different product types

class Program
{
    public void Main()
    {
        
    }
}
