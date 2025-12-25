using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class BankAccount
    {
        public static int GetFinalBalance(int initialBalance, int[] transactions)
        {
            int balance = initialBalance;
            foreach (int t in transactions)
            {
                if (t >= 0) balance += t;
                else if (balance + t >= 0) balance += t;
            }
            return balance;
        }
    }
}
