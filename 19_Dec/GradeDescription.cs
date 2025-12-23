//Grade Description: Input grade (E, V, G, A, F) and print (Excellent, Very Good, Good, Average, Fail) using switch.

using System;

public class GradeDescription
{
    public static void Run()
    {
        Console.Write("Enter grade (E, V, G, A, F): ");
        char grade = Char.ToUpper(Console.ReadLine()[0]);

        string description = GetGradeDescription(grade);
        Console.WriteLine(description);
    }

    private static string GetGradeDescription(char grade)
    {
        switch (grade)
        {
            case 'E':
                return "Excellent";
            case 'V':
                return "Very Good";
            case 'G':
                return "Good";
            case 'A':
                return "Average";
            case 'F':
                return "Fail";
            default:
                return "Invalid grade entered.";
        }
    }
}