// See https://aka.ms/new-console-template for more information

namespace SmartBank
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter employment type: ");
            string employmentType = Console.ReadLine();

            Console.Write("Enter monthly income: ");
            double monthlyIncome = double.Parse(Console.ReadLine());

            Console.Write("Enter existing credit dues: ");
            double dues = double.Parse(Console.ReadLine());

            Console.Write("Enter credit score: ");
            int creditScore = int.Parse(Console.ReadLine());

            Console.Write("Enter number of loan defaults: ");
            int defaults = int.Parse(Console.ReadLine());

            CreditRiskProcessor crpObj = new CreditRiskProcessor();

            try
            {
                if (crpObj.validateCustomerDetails(age, employmentType, monthlyIncome, dues, creditScore, defaults))
                {
                    Console.WriteLine($"cUSTOMER NAME : {customerName}");
                    Console.WriteLine($"CREDITLIMIT :  {crpObj.calculateCreditLimit(monthlyIncome, dues, creditScore, defaults)}");
                }
            }
            catch (InvalidCreditDataException ex)
            {
              Console.WriteLine(ex.ToString());
            }
        }
    }
}