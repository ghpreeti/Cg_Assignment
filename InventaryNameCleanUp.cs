using System.Text;

class InventaryNameCleanUp
{
    
    public static string ToTitleCase(string input)
    {
        string[] words = input.ToLower().Split(' ');

        StringBuilder sb = new StringBuilder();

        foreach(string word in words)
        {
            if (word.Length > 0)
            {
                sb.Append(char.ToUpper(word[0]));
                if (word.Length > 0)
                {
                    sb.Append(word.Substring(1));
                    sb.Append(" ");
                }

            }
        }
        return sb.ToString().Trim();

    }
        public static string Converting(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        return string.Empty;

    
        str = str.Trim();
        StringBuilder str1 = new StringBuilder();

        char prev = "\0";
        foreach(char c in str)
        {
            if (c != prev)
            {
                str1.Append(c);
                prev =c;
            }
        }

        string cleaned = string.Join(' ',str1.ToString());

        
    }
}