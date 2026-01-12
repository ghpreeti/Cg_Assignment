// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public decimal CurrentBalance { get; set; }
    public Program() { }
    
    public Program(decimal initialBalance)
    {
        CurrentBalance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            CurrentBalance += amount;
        }
        else
        {
            Console.WriteLine("Deposit amount cannot be negative.");
        }
    }

    public void Withdraw(decimal amount) {

        if (amount > CurrentBalance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            CurrentBalance -= amount;
        }
    }
    static void Main()
    {
        
    }
}