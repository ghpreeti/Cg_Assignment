using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class TokenSum
    {
        public static int SumIntegers(string[] tokens)
        {
            int sum = 0;
            foreach (string t in tokens)
            {
                if (int.TryParse(t, out int value))
                    sum += value;
            }
            return sum;
        }
    }
}

