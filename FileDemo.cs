class FileDemo
{
    static void Main()
    {
        string input = "log.txt";
        string output = "error.txt";

        string[] lines = File.ReadAllLines(input);

        using(StreamWriter writer = new StreamWriter(output))
        {
            foreach(string line in lines)
            {
                if(line.StartsWith("ERROR")){writer.WriteLine(line);}
            }
        }
        Console.WriteLine("ERROR extracted sucessfully");
    }
}