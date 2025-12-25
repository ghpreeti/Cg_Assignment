using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class PositiveSum
    {
        public static int SumUntilZero(int[] nums)
        {
            int sum = 0;
            foreach (int n in nums)
            {
                if (n == 0) break;
                if (n < 0) continue;
                sum += n;
            }
            return sum;
        }
    }
}