//Triangle Type: Check if a triangle is Equilateral, Isosceles, or Scalene based on side lengths.

using System;

public class TriangleType
{
    public static void Run()
    {
        ///{summary>
        /// Assuming triangle abc with sides: AB, BC, CA
        /// </summary>
        
        Console.WriteLine("Enter length of side A: ");
        int ab = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter length of side B: ");
        int bc = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter length of side C: ");
        int ca = Int32.Parse(Console.ReadLine());

        if (ab == bc && bc == ca)
        {
            Console.WriteLine("Equilateral Triangle");
        }
        else if (ab == bc || bc == ca || ab == ca)
        {
            Console.WriteLine("Isosceles Triangle");
        }
        else
        {
            Console.WriteLine("Scalene Triangle");
        }
    }
}