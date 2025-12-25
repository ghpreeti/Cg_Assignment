using System;
using System.Collections.Generic;
using System.Text;



namespace AssignmentPrac
{
    public class ArraySummary
    {
        public static string GetSummary(int[] nums)
        {
            int min = nums[0], max = nums[0], sum = 0;
            foreach (int n in nums)
            {
                if (n < min) min = n;
                if (n > max) max = n;
                sum += n;
            }
            double avg = Math.Round((double)sum / nums.Length, 2, MidpointRounding.AwayFromZero);
            return $"min={min}; max={max}; sum={sum}; avg={avg}";
        }
    }
}
