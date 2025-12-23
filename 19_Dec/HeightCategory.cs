//Height Category: Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).
using System;

public class HeightCategory
{
    public static void Run()
    {
        Console.Write("Enter your height in cm: ");
        int height = Int32.Parse(Console.ReadLine());

        if (height < 150)
        {
            Console.WriteLine("Dwarf");
        }
        else if (height >= 150 && height <= 165)
        {
            Console.WriteLine("Average");
        }
        else if (height > 165 && height <= 190)
        {
            Console.WriteLine("Tall");
        }
        else
        {
            Console.WriteLine("Abnormal");
        }
    }
}