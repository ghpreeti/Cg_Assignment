//ATM Withdrawal: Nested if to check: 1. Card inserted, 2. Pin valid, 3. Balance sufficient.
using System;

public class ATMWithdrawal
{
    public static void Run()
    {
        int actualPin = 4567; // assuming 4567 is the valid PIN
        double avlBalance = 10000.0; // assuming initial balance is 1000

        Console.WriteLine("Is card inserted? (True/false): "); 
        bool card = Boolean.Parse(Console.ReadLine());

        if (card)
        {
            Console.WriteLine("Enter PIN: ");
            int pin = Int32.Parse(Console.ReadLine());

            if (pin == actualPin)
            {
                Console.WriteLine("Enter withdrawal amount: ");
                double amount = Double.Parse(Console.ReadLine());
                
                if (amount <= avlBalance)
                {
                    avlBalance -= amount;
                    Console.WriteLine("Withdrawal successful. Remaining balance: {0}",avlBalance);
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN.");
            }
        }
        else
        {
            Console.WriteLine("Please insert your card.");
        }

    }
}