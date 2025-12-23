//Vowel or Consonant: Use a switch statement to check if a character is a vowel.

using System;

public class VowelOrConsonant
{
    public static void Run()
    {
        Console.WriteLine("Enter a character: ");
        char ch = Char.ToLower(Console.ReadLine()[0]);

        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("{0} is a vowel.", ch);
                break;
            default:
                if (Char.IsLetter(ch))// Check if it's an alphabetic character
                {
                    Console.WriteLine("{0} is a consonant.", ch);
                }
                else
                {
                    Console.WriteLine("{0} is not an alphabetic character.", ch);
                }
                break;
        }
    }
}