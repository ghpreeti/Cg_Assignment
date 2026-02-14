using System;
using System.Text.RegularExpressions;

// 1. Interface for probation
public interface IProbation
{
    void StartProbation();
}

// 2. Abstract Employee class
public abstract class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string EmployeeId { get; set; }

    public abstract void DisplayRole();
}

// Concrete employee class
public class FullTimeEmployee : Employee, IProbation
{
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Full Time Employee");
    }

    public void StartProbation()
    {
        Console.WriteLine("Probation started for employee.");
    }
}

// 3. Extension method for name formatting
public static class NameExtensions
{
    public static string FormatName(this Employee emp)
    {
        return $"{emp.LastName.ToUpper()}, {emp.FirstName}";
    }
}

// 4. Onboarding class with Regex validation
public class Onboarding
{
    public (bool isSuccess, string message) Register(Employee emp)
    {
        string emailPattern = @"^[a-zA-Z0-9]+@.+(\.com|\.in)$";
        string idPattern = @"^EMP-\d{4}$";

        if (!Regex.IsMatch(emp.Email, emailPattern))
        {
            return (false, "Invalid Email");
        }

        if (!Regex.IsMatch(emp.EmployeeId, idPattern))
        {
            return (false, "Invalid Employee ID");
        }

        return (true, "Employee Onboarded Successfully");
    }
}

// 5. Test Program
class Program
{
    static void Main()
    {
        FullTimeEmployee emp = new FullTimeEmployee
        {
            FirstName = "Preeti",
            LastName = "Singh",
            Email = "preeti@gmail.com",
            EmployeeId = "EMP-1234"
        };

        Onboarding ob = new Onboarding();
        var result = ob.Register(emp);

        if (result.isSuccess)
        {
            Console.WriteLine(result.message);
            Console.WriteLine("Formatted Name: " + emp.FormatName());
            emp.DisplayRole();
            emp.StartProbation();
        }
        else
        {
            Console.WriteLine(result.message);
        }
    }
}
