//Simple Calculator: Use switch to perform +, -, *, / based on user operator input.

using System;

public class SimpleCalculator
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        double num1 = Double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        char op = Console.ReadLine()[0];
        Console.Write("Enter second number: ");
        double num2 = Double.Parse(Console.ReadLine());

        double result;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                return;
        }

        Console.WriteLine("Result: {0}", result);
    }
}