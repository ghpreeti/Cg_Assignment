using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class LargestNumber
    {
        public static int GetLargest(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
    }
}