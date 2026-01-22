class Parsing{

public static int SumValidIntegers(string[] tokens)
{
    int sum = 0;

    foreach (string token in tokens)
    {
        if (int.TryParse(token, out int value))
        {
            sum += value;
        }
    }

    return sum;
}
}