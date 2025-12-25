using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class ObjectSum
    {
        public static int SumInts(object[] values)
        {
            int sum = 0;
            foreach (var v in values)
            {
                if (v is int x)
                    sum += x;
            }
            return sum;
        }
    }
}

