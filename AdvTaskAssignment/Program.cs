// See https://aka.ms/new-console-template for more information
using AdvTaskAssignment1;

public class Program
{
    static void Main()
    {
        Console.Write("Enter Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string empName = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        // Step 2: Age Validation
        if (age < 21)
        {
            Console.WriteLine("Employee is not eligible to work");
            return;
        }

        Console.WriteLine("Select Department:");
        Console.WriteLine("1. IT");
        Console.WriteLine("2. HR");
        Console.WriteLine("3. Finance");
        Console.Write("Enter your choice: ");
        int deptChoice = int.Parse(Console.ReadLine());

        Console.Write("Enter Basic Salary: ");
        double basicSalary = double.Parse(Console.ReadLine());

        string department = "";
        string role = "";
        double allowance = 0;

        // Step 3: Department & Role Selection (Nested Switch)
        switch (deptChoice)
        {
            case 1:
                department = "IT";
                Console.WriteLine("Select Role:");
                Console.WriteLine("1. Developer");
                Console.WriteLine("2. Tester");
                int itRole = int.Parse(Console.ReadLine());

                switch (itRole)
                {
                    case 1:
                        role = "Developer";
                        allowance = 30;
                        break;
                    case 2:
                        role = "Tester";
                        allowance = 25;
                        break;
                    default:
                        Console.WriteLine("Invalid Role Selection");
                        return;
                }
                break;

            case 2:
                department = "HR";
                Console.WriteLine("Select Role:");
                Console.WriteLine("1. Recruiter");
                Console.WriteLine("2. Payroll");
                int hrRole = int.Parse(Console.ReadLine());

                switch (hrRole)
                {
                    case 1:
                        role = "Recruiter";
                        allowance = 20;
                        break;
                    case 2:
                        role = "Payroll";
                        allowance = 22;
                        break;
                    default:
                        Console.WriteLine("Invalid Role Selection");
                        return;
                }
                break;

            case 3:
                department = "Finance";
                Console.WriteLine("Select Role:");
                Console.WriteLine("1. Accountant");
                Console.WriteLine("2. Auditor");
                int finRole = int.Parse(Console.ReadLine());

                switch (finRole)
                {
                    case 1:
                        role = "Accountant";
                        allowance = 28;
                        break;
                    case 2:
                        role = "Auditor";
                        allowance = 26;
                        break;
                    default:
                        Console.WriteLine("Invalid Role Selection");
                        return;
                }
                break;

            default:
                Console.WriteLine("Invalid Department Selection");
                return;
        }

        // Step 4: Salary Calculation
        double finalSalary = basicSalary + (basicSalary * allowance / 100);

        // Step 5: Access Level Decision
        string accessLevel;
        if (finalSalary >= 60000 && department == "IT")
        {
            accessLevel = "Admin Access";
        }
        else if (finalSalary >= 60000)
        {
            accessLevel = "Manager Access";
        }
        else
        {
            accessLevel = "Employee Access";
        }

        // Step 6: Output
        Console.WriteLine("\n--- Employee Details ---");
        Console.WriteLine($"Employee ID    : {empId}");
        Console.WriteLine($"Employee Name  : {empName}");
        Console.WriteLine($"Department     : {department}");
        Console.WriteLine($"Role           : {role}");
        Console.WriteLine($"Basic Salary   : {basicSalary}");
        Console.WriteLine($"Final Salary   : {finalSalary}");
        Console.WriteLine($"Access Level   : {accessLevel}");
    }
}
