using System;
using System.Text.RegularExpressions;

// Scenario
// A fintech application allows users to register using email, mobile number, and password.
// Due to regulatory requirements, strict validation must be applied before saving data.
// Problem Statement
// Write a C# program that validates user input using Regular Expressions.
// Validation Rules
// •	Email:
// o	Must follow standard email format
// o	Domain must be .com or .in
// •	Mobile Number:
// o	Must be exactly 10 digits
// o	Can optionally start with country code +91
// •	Password:
// o	Minimum 8 characters
// o	At least 1 uppercase, 1 lowercase, 1 digit, 1 special character
// •	PAN Number:
// o	Format: ABCDE1234F
// Input
// User details as strings
// Output
// A validation report:
// Email: Valid
// Mobile: Invalid
// Password: Valid
// PAN: Valid

class RegexProgram
{
    public void ValidateInput(string email, string phoneNo, string password,string panNo)
    {
        string emailPattern = @"^[a-zA-Z0-9]+@.+(\.com|\.in)$";
        Console.WriteLine(Regex.IsMatch(email, emailPattern) 
            ? "Email: Valid" 
            : "Email: Invalid");

        string phonePattern = @"^(\+91)?[0-9]{10}$";
        Console.WriteLine(Regex.IsMatch(phoneNo, phonePattern) 
            ? "Mobile: Valid" 
            : "Mobile: Invalid");

        string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$";
        Console.WriteLine(Regex.IsMatch(password, passwordPattern) 
            ? "Password: Valid" 
            : "Password: Invalid");

        string panPattern = @"^[A-Z]{5}[0-9]{4}[A-Z]$";
        Console.WriteLine(Regex.IsMatch(panNo, panPattern) 
            ? "PAN: Valid" 
            : "PAN: Invalid");
        
    }
    public static void Main()
    {
         Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Mobile Number: ");
        string phone = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        Console.Write("Enter PAN Number: ");
        string pan = Console.ReadLine();

        RegexProgram obj = new RegexProgram();
        obj.ValidateInput(email, phone, password, pan);
    }
}