using System;
using System.Text;
using System.Threading.Channels;

public class Solution
{
    public string AlphabetsandVowels(string str1,string str2)
    {
       string vowels = "aeiou";
       HashSet<char> consonant = new HashSet<char>();
       foreach(char c in str2.ToLower())
        {
            if (!vowels.Contains(c)) 
            {
                consonant.Add(c);
            }
        }

          StringBuilder sb = new StringBuilder();

        foreach(char c in str1)
        {
            char lower = Char.ToLower(c);
            if(vowels.Contains(lower) || !consonant.Contains(lower))
            {
                sb.Append(c);
            }
        }

        StringBuilder result = new StringBuilder();
        char pre = '\0';
        foreach(char c in sb.ToString())
        {
            if(c != pre)
            {
                result.Append(c);
                pre = c;
            }
        }
        
        
        return result.ToString();
        
    }
    
}