// See https://aka.ms/new-console-template for more information
using System;

public class User
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
}

public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException(string message) : base(message) { }
}

public class Program
{
    public User ValidatePhoneNumber(string name, string phoneNumber)
    {
        if (phoneNumber != null && phoneNumber.Length == 10)
        {
            return new User
            {
                Name = name,
                PhoneNumber = phoneNumber
            };
        }

        throw new InvalidPhoneNumberException("Invalid phone number");
    }

    public static void Main()
    {
        Program p = new Program();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter phone number: ");
        string phone = Console.ReadLine();

        try
        {
            User u = p.ValidatePhoneNumber(name, phone);
            Console.WriteLine("User Verified");
        }
        catch (InvalidPhoneNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}