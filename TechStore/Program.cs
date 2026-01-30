// See https://aka.ms/new-console-template for more information
using System;
using TechStore;

class Program
{
    static void Main()
    {
        GadgetValidatorUtil gObj = new GadgetValidatorUtil();

        Console.WriteLine("Enter the number of entries");
        int entries = int.Parse(Console.ReadLine());

        for (int i = 1; i <= entries; i++)
        {
            Console.WriteLine($"\nEnter entry {i} details");

            string input = Console.ReadLine();

            try
            {
                string[] parts = input.Split(':');

                string gadgetID = parts[0];
                string gadgetType = parts[1];
                int warrantyPeriod = int.Parse(parts[2]);

                gObj.validateGadgetID(gadgetID);
                gObj.validateGadgetType(gadgetType);
                gObj.validateWarrantyPeriod(warrantyPeriod);

                Console.WriteLine("Warranty accepted, stock updated");

            }
            catch (InvalidGadgetException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
