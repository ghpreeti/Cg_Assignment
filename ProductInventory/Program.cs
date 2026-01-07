// See https://aka.ms/new-console-template for more information
using ProductInventory;

class Program
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        IInventory inventory = new Inventory(); 
        int pCount = Convert.ToInt32(Console.ReadLine().Trim()); 
        
        for (int i = 1; i <= pCount; i++)
        {
            var a = Console.ReadLine().Trim().Split(" "); 
            Product e = new Product();
            e.Name = a[0];
            e.Category = a[1];
            e.Stock = Convert.ToInt32(a[2]);
            e.Price = Convert.ToInt32(a[3]); inventory.AddProduct(e);
        }

        var b = Console.ReadLine().Trim().Split(" "); 
        var randomCategoryName = b[0];
        var randomProductName = b[1];
        string productName = b[2];

        var getProductsByCategory = inventory.GetProductsByCategory(randomCategoryName); 
        textWriter.WriteLine($"{randomCategoryName}:"); 

        foreach (var product in getProductsByCategory.OrderBy(a => a.Name))
        { textWriter.WriteLine($"Product Name:{product.Name} Category:{product.Category}"); }

        var searchProductsByName = inventory.SearchProductsByName(randomProductName); 
        textWriter.WriteLine($"{randomProductName}:"); 

        foreach (var product in searchProductsByName.OrderBy(a => a.Name))
        { textWriter.WriteLine($"Product Name:{product.Name} Category:{product.Category}"); }

        textWriter.WriteLine("Total Value:$" + inventory.CalculateTotalValue());
        var getProductsByCategoryWithCount = inventory.GetProductsByCategoryWithCount(); 
        
        foreach (var item in getProductsByCategoryWithCount.OrderBy(a => a.Item1))
        {
            textWriter.WriteLine($"{item.Item1}:{item.Item2}");
        }

        var getAllProductsByCategory = inventory.GetAllProductsByCategory(); 
        foreach (var item in getAllProductsByCategory.OrderBy(a => a.Item1))
        {
            textWriter.WriteLine($"{item.Item1}:"); foreach (var item2 in item.Item2)
            {
                textWriter.WriteLine($"Product Name:{item2.Name} Price:{item2.Price}");
            }
        }


        var productsToDelete = inventory.SearchProductsByName(productName);
        foreach (var product in productsToDelete)
        {
            inventory.RemoveProduct(product);
        }
        textWriter.WriteLine("New Total Value:$" + inventory.CalculateTotalValue()); 
        textWriter.Flush(); 
        textWriter.Close();
    }
}

