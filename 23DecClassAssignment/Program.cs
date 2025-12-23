// See https://aka.ms/new-console-template for more information
using _23DecClassAssignment;


class Program
{
    static void Main()
    {
        Console.WriteLine("1. Desktop");
        Console.WriteLine("2. Laptop");
        Console.Write("Choose the option: ");
        int choice = Int32.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Desktop desktop = new Desktop();

            Console.Write("Enter the processor: ");
            desktop.Processor = Console.ReadLine();

            Console.Write("Enter the ram size: ");
            desktop.RamSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the hard disk size: ");
            desktop.HardDiskSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the graphic card size: ");
            desktop.GraphicCard = int.Parse(Console.ReadLine());

            Console.Write("Enter the monitor size: ");
            desktop.MonitorSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the power supply volt: ");
            desktop.PowerSupplyVolt = int.Parse(Console.ReadLine());

            double price = desktop.DesktopPriceCalculation();
            Console.WriteLine($"Desktop price is {price}");
        }
        else if (choice == 2)
        {
            Laptop laptop = new Laptop();

            Console.Write("Enter the processor: ");
            laptop.Processor = Console.ReadLine();

            Console.Write("Enter the ram size: ");
            laptop.RamSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the hard disk size: ");
            laptop.HardDiskSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the graphic card size: ");
            laptop.GraphicCard = int.Parse(Console.ReadLine());

            Console.Write("Enter the display size: ");
            laptop.DisplaySize = int.Parse(Console.ReadLine());

            Console.Write("Enter the battery volt: ");
            laptop.BatteryVolt = int.Parse(Console.ReadLine());

            double price = laptop.LaptopPriceCalculation();
            Console.WriteLine($"Laptop price is {price}");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
