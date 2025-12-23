//Quadrant Finder: Take (x,y) coordinates and print which quadrant they lie in.

using System;

public class QuadrantFinder
{
    public static void Run()
    {
        Console.WriteLine("Enter x:");
        int x = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter y:");
        int y = Int32.Parse(Console.ReadLine());

        if (x>0 && y>0)
        {
            Console.WriteLine("The point is in Quadrant 1.");
        }
        else if (x<0 && y>0)
        {
            Console.WriteLine("The point is in Quadrant 2.");
        }
        else if (x<0 && y<0)
        {
            Console.WriteLine("The point is in Quadrant 3.");
        }
        else if (x>0 && y<0)
        {
            Console.WriteLine("The point is in Quadrant 4.");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine("The point is on the Y axis.");
        }
        else if (y == 0 && x != 0)
        {
            Console.WriteLine("The point is on the X axis.");
        }
        else
        {
            Console.WriteLine("The point is at the origin.");
        }
    }
}