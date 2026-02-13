using System;
using System.Collections.Generic;
using System.Linq;

// Scenario 1: E-Commerce Inventory System
// Problem: Design a flexible inventory system that can handle different product categories with varying attributes while maintaining type safety. 
// csharp
// Base product interface
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
        if(!string.IsNullOrEmpty(product.Name) && product.Price >0 && !_products.Any(p=>p.Id == product.Id))
        {
            _products.Add(product);
        }
          
        // Rule: Product ID must be unique
        // Rule: Price must be positive
        // Rule: Name cannot be null or empty
        // Add to collection if validation passes
    }
    
public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        // Should return filtered products
        return _products.Where(predicate);
        
    }
    
    // TODO: Calculate total inventory value
    public decimal CalculateTotalValue()
    {
        // Return sum of all product prices
        return _products.Sum(p=>p.Price);
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
        if(discountPercentage >= 0 || discountPercentage < 100)
        {
            _product = product;
            _discountPercentage = discountPercentage;
        }
    }
    
    // TODO: Implement calculated price with discount
    public decimal DiscountedPrice => _product.Price * (1 - _discountPercentage / 100);

    // TODO: Override ToString to show discount details
    public override string ToString()
    {
        return $"{_product.Name} - Original: {_product.Price:C}, Discount: {_discountPercentage}%, Discounted: {DiscountedPrice:C}";
    }
}

// 4. Inventory manager with constraints
public class InventoryManager
{
    // TODO: Create method that accepts any IProduct collection
    public void ProcessProducts<T>(IEnumerable<T> products) where T : IProduct
    {
        // a) Print all product names and prices
          foreach(var p in products)
        {
            Console.WriteLine($"{p.Name}:{p.Price}");
        }

        // b) Find the most expensive product
        var expensive = products.OrderByDescending(price=>price.Price).First();
        Console.WriteLine($"Most expensive {expensive.Name}: {expensive.Price}");

        // c) Group products by category
        var group = products.GroupBy(c=>c.Category).Select(g=> new {Category=g.Key, ProductNames = g.Select(p=>p.Name).ToList()});

        // d) Apply 10% discount to Electronics over $500
    var discounted = products.Where(c=>c.Category == Category.Electronics && c.Price > 500).Select(p => new
    {
        Product = p,
        DiscountedPrice = p.Price *0.9m
        
    });


    }
    
    // TODO: Implement bulk price update with delegate
    public void UpdatePrices<T>(List<T> products, Func<T, decimal> priceAdjuster) 
        where T : IProduct
    {
        // Apply priceAdjuster to each product
        foreach(var p in products)
        {
            p.Price = priceAdjuster(p);
        }
        // Handle exceptions gracefully
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


