// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using ProductInventory;

class Program
{
    public static void Main(string[] args)
    {
        var outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        TextWriter textWriter;

        if (string.IsNullOrWhiteSpace(outputPath))
        {
            textWriter = Console.Out;
        }
        else
        {
            textWriter = new StreamWriter(outputPath, append: true);
        }

        try
        {
            IInventory inventory = new Inventory();

            // Sample data for testing
            List<Product> sampleProducts = new List<Product>
            {
                new Product { Name = "Apple", Category = "Fruit", Stock = 10, Price = 2 },
                new Product { Name = "Banana", Category = "Fruit", Stock = 5, Price = 1 },
                new Product { Name = "Carrot", Category = "Vegetable", Stock = 8, Price = 3 },
                new Product { Name = "Milk", Category = "Dairy", Stock = 2, Price = 4 }
            };

            foreach (var p in sampleProducts)
            {
                inventory.AddProduct(p);
            }

            string randomCategoryName = "Fruit";
            string randomProductName = "Apple";
            string productName = "Banana";

            var getProductsByCategory = inventory.GetProductsByCategory(randomCategoryName);
            textWriter.WriteLine($"{randomCategoryName}:");

            foreach (var product in getProductsByCategory.OrderBy(p => p.Name))
            {
                textWriter.WriteLine($"Product Name:{product.Name} Category:{product.Category}");
            }

            var searchProductsByName = inventory.SearchProductsByName(randomProductName);
            textWriter.WriteLine($"{randomProductName}:");

            foreach (var product in searchProductsByName.OrderBy(p => p.Name))
            {
                textWriter.WriteLine($"Product Name:{product.Name} Category:{product.Category}");
            }

            textWriter.WriteLine("Total Value:$" + inventory.CalculateTotalValue());

            var productsToDelete = inventory.SearchProductsByName(productName);
            foreach (var product in productsToDelete)
            {
                inventory.RemoveProduct(product);
            }
            textWriter.WriteLine("New Total Value:$" + inventory.CalculateTotalValue());
        }
        finally
        {
            if (textWriter is StreamWriter sw)
            {
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
        }
    }
}

