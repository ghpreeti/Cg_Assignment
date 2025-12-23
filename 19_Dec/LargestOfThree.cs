//Largest of Three: Take three integers and find the maximum using nested if.
using System;

public class LargestOfThree
{
    public static void Run()
    {
        Console.Write("Enter num1: ");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.Write("Enter num2: ");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.Write("Enter num3: ");
        int num3 = Int32.Parse(Console.ReadLine());

        int largest=0;

        if (num1 >= num2)
        {
            if (num1 >= num3)
            {
                largest = num1;
            }
            else
            {
                largest = num3;
            }
        }
        else
        {
            if (num2 >= num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }
        }

        Console.WriteLine("The largest num is {0}",largest);
    }
}