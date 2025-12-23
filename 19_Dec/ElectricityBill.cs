//Electricity Bill: Calculate bill: First 199 units @ 1.20; 200-400 @ 1.50; 400-600 @ 1.80; above 600 @ 2.00. Add 15% surcharge if bill > 400.

using System;

public class ElectricityBill
{
    public static void Run()
    {
        double billAmount = 0.0; // initialize bill amount
        Console.Write("Enter the number of units consumed: ");
        int units = Int32.Parse(Console.ReadLine());
        
        if (units <= 199)
        {
            billAmount = units * 1.20;
        }
        else if (units >= 200 && units < 400)
        {
            billAmount = (199 * 1.20) + ((units - 199) * 1.50); // first 199 units + remaining units
        }
        else if (units >= 400 && units < 600)
        {
            billAmount = (199 * 1.20) + (200 * 1.50) + ((units - 399) * 1.80); // first 199 + next 200 + remaining units
        }
        else // units >= 600
        {
            billAmount = (199 * 1.20) + (200 * 1.50) + (200 * 1.80) + ((units - 599) * 2.00);// first 199 + next 200 + next 200 + remaining units
        }

        if (billAmount > 400)
        {
            billAmount += billAmount * 0.15; // adding 15% surcharge
        }

        Console.WriteLine("Total Electricity Bill: {0}",billAmount);
    }
}