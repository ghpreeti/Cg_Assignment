using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationBankingNUnit
{
    public class Program
    {
        public decimal Balance { get; set; }

        public Program(decimal iniBalance)
        {
            Balance = iniBalance;
        }

        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new Exception("Amount cannot be negative");
            }
            else
            {
                Balance += amount;
            }
        }
         public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new Exception("Insufficient funds");
            }
            else
            {
                Balance -= amount;
            }
        }

    }
}
