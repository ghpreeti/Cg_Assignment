//Profit/Loss: Calculate profit or loss percentage based on Cost Price and Selling Price.

using System;

public class ProfitLoss
{
    public static void Run()
    {
     ///{summary>}
     /// loss = CP - SP
     /// profit = SP - CP   
     /// loss% = (loss/CP) * 100
     /// profit% = (profit/CP) * 100
     /// </summary>

        Console.Write("Enter CP: "); //Cost Price
        double cp = Double.Parse(Console.ReadLine());

        Console.Write("Enter SP: ");//Selling Price
        double sp = Double.Parse(Console.ReadLine());

        if (sp>cp)
        {
            double profit = sp - cp;
            double profitPercentage = (profit / cp) * 100;
            Console.WriteLine("Profit: {0}, Profit Percentage: {0}%",profit,profitPercentage);
        }
        else if (cp>sp)
        {
            double loss = cp - sp;
            double lossPercentage = (loss / cp) * 100;
            Console.WriteLine("Loss: {0}, Loss Percentage: {0}%",loss,lossPercentage);
        }
        else
        {
            Console.WriteLine("No Profit, No Loss.");
        }
    }
}
