// See https://aka.ms/new-console-template for more information
using _23DecAssig3;

class Program
{
    
    public static Candy CalculateDiscountedPrice(Candy candy)
    {
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
        candy.TotalPrice -= (candy.TotalPrice * candy.Discount / 100);
        return candy;
    }
    static void Main()
    {
        Candy c = new Candy();
        Console.WriteLine("Enter Candy Flavour:");
        c.Flavour = Console.ReadLine().ToLower();
        Console.WriteLine("Enter the quantity :");
        c.Quantity = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the price per piece :");
        c.PricePerPiece = Int32.Parse(Console.ReadLine());

        try
        {
            if (c.ValidateCandyFlavour())
            {
                c.Discount = c.DiscountPercentage();

                Candy discountedPrice = CalculateDiscountedPrice(c);

                Console.WriteLine($"Flavour : {c.Flavour}");
                Console.WriteLine($"Quantity : {c.Quantity}");
                Console.WriteLine($"Price Per Piece : {c.PricePerPiece}");
                Console.WriteLine($"Total Price : {c.TotalPrice}");
                Console.WriteLine($"Discount Price : {discountedPrice}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
