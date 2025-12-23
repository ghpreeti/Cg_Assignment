// See https://aka.ms/new-console-template for more information
using _23DecAssig2;

class Program
{
    public static void Main()
    {
        Cake cake = new Cake();
        Console.WriteLine("Enter the flavor (Chocolate or Red Velvet or Vanilla):\r\n");
        cake.Flavor = Console.ReadLine().ToLower();
        Console.WriteLine("Enter the price per kg\r\n");
        cake.PricePerKg = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the quantity in kg\r\n");

        cake.QuantityInKg = int.Parse(Console.ReadLine());

        try
        {
            if (cake.CakeOrder())
            {
                double finalPrice = cake.CalculatePrice();
                Console.WriteLine($"The final price of the cake is: {finalPrice}");
            }
        }
        catch (InvalidFlavourException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
