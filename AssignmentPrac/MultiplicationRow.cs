using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class MultiplicationRow
    {
        public static int[] GetRow(int n, int upto)
        {
            int[] result = new int[upto];
            for (int i = 1; i <= upto; i++)
                result[i - 1] = n * i;
            return result;
        }
    }
}
