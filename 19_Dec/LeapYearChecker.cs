//Leap Year Checker: Determine if a year is leap (Divisible by 400 OR (Divisible by 4 and NOT 100)).

using System;

public class LeapYearChecker
{
    public static void Run()
    {
        Console.Write("Enter a year: ");
        int year = Int32.Parse(Console.ReadLine());
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}