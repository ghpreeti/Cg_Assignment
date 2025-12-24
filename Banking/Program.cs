// See https://aka.ms/new-console-template for more information


using Banking;

class Program
{
    static void Main(string[] args)
    {
        // Create a customer
        Customer customer = new Customer(1, "John Doe", "123 Main St", "Active", "555-1234");
        // Create an agency
        Agency agency = new Agency("Best Agency", "456 Agency Rd", "555-5678");
        // Verify the customer through the agency
        string verificationResult = agency.VerifyCustomer(customer);
        Console.WriteLine(verificationResult); // Output: Customer John Doe is Green.
    }
}