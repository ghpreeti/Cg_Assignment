//Rock Paper Scissors: Logic for a 2-player game using nested conditionals.

using System;

public class RockPaperScissors
{
    public static void Run()
    {
        Console.WriteLine("Enter choice for Player 1 (rock, paper, scissors): ");
        string p1 = Console.ReadLine().ToLower();

        Console.WriteLine("Enter choice for Player 2 (rock, paper, scissors): ");
        string p2 = Console.ReadLine().ToLower();

        if (p1 == p2)
        {
            Console.WriteLine("It's a tie!");
        }
        else if (p1 == "rock")
        {
            if (p2 == "scissors")
            {
                Console.WriteLine("Player 1 wins! Rock crushes Scissors.");
            }
            else if (p2 == "paper")
            {
                Console.WriteLine("Player 2 wins! Paper covers Rock.");
            }
            else
            {
                Console.WriteLine("Invalid input from Player 2.");
            }
        }
        else if (p1 == "paper")
        {
            if (p2 == "rock")
            {
                Console.WriteLine("Player 1 wins! Paper covers Rock.");
            }
            else if (p2 == "scissors")
            {
                Console.WriteLine("Player 2 wins! Scissors cut Paper.");
            }
            else
            {
                Console.WriteLine("Invalid input from Player 2.");
            }
        }
        else if (p1 == "scissors")
        {
            if (p2 == "paper")
            {
                Console.WriteLine("Player 1 wins! Scissors cut Paper.");
            }
            else if (p2 == "rock")
            {
                Console.WriteLine("Player 2 wins! Rock crushes Scissors.");
            }
            else
            {
                Console.WriteLine("Invalid input from Player 2.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input from Player 1.");
        }
    }
}