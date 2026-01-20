class BankTransaction
{
    public static int ProcessTransaction(int initialBalance,int[] transactions)
    {
        int balance = initialBalance;
        foreach (int amount in transactions)
        {
            if (amount >= 0)
            {
                balance += amount;
            }else if(amount < 0)
            {
                balance -= Math.Abs(amount);
            }
        }
       return balance;
    }
}