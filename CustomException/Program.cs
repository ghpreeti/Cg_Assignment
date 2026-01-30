// See https://aka.ms/new-console-template for more information
using CustomException;
using System;

public class Program
{
    public static void Main()
    {
        EntryUtility enObj = new EntryUtility();

        Console.WriteLine("Enter the number of entries");
        int entries = int.Parse(Console.ReadLine());

        for (int i = 1; i <= entries; i++)
        {
            Console.WriteLine($"\nEnter entry {i} details");

            string input = Console.ReadLine();

            try
            {
                string[] parts = input.Split(':');

                string empId = parts[0];
                string department = parts[1];
                int duration = int.Parse(parts[2]);

                enObj.ValidateEmployeeId(empId);
                enObj.ValidateDepartment(department);
                enObj.ValidateDuration(duration);

                Console.WriteLine("Valid entry details");
            }
            catch (InvalidEntryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }

}
