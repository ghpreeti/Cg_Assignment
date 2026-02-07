class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();
    
    public static void Main()
    {
        BikeUtility bObj = new BikeUtility();
        while (true)
        {
            Console.WriteLine("1. Add Bike Details: ");
            Console.WriteLine("2. Group Bikes by Brand: ");
            Console.WriteLine("3. Exit");

            Console.WriteLine("Enter your Choice :");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        
                    }
            }
        }
    }

}

public class Bike
{
    public string Model{get; set;}
    public string Brand{get; set;}
    public int PricePerDay{get; set;}

}

public class BikeUtility
{
    
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
       
           int count = Program.bikeDetails.Count();

            Program.bikeDetails.Add(count+1, new Bike(){Model=model, Brand = brand, PricePerDay = pricePerDay});
       
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string,List<Bike>> bikeByBrand = new SortedDictionary<string, List<Bike>>(); 
        
        var query = Program.bikeDetails.Values.GroupBy(b=>b.Brand).ToDictionary(g=>g.Key,g=>g.ToList());
        // foreach(var grp in query)
        // {
        //     Console.WriteLine(grp.Key);
        //     foreach(var bike in grp)
        //     {
        //         bikeByBrand.Add(grp, new List<Bike>{})
        //     }
        // }

        return query;
    }

}