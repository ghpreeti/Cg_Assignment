//Valid Date Check: Input day/month/year and check if it's a valid calendar date (handle Feb 29).

using System;

public class ValidDateCheck
{
    public static void Run()
    {
        Console.Write("Enter day: ");
        int day =   Int32.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = Int32.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = Int32.Parse(Console.ReadLine());

        bool isValidDate = IsValidDate(day, month, year);
        if (isValidDate)
        {
            Console.WriteLine("The date is valid.");
        }
        else
        {
            Console.WriteLine("The date is invalid.");
        }
    }

    private static bool IsValidDate(int day, int month, int year)
    {
        
    }

    private static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}