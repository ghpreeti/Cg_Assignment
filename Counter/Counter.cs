using System;
using System.Collections.Generic;
using System.Text;

namespace CounterTask
{
    public class Counter
    {
        int[] data = null;
        public Counter(){}
        public Counter(int[] arr)
        {
            data = arr;
        }
        public string GetCount()
        {
            int count0 = 0;
            int count1 = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 0)
                {
                    count0++;
                }
                else if (data[i] == 1)
                {
                    count1++;

                }

            }
            if (count0 % 2 == 0 && count1 % 2 == 0)
            {
                return "Great";
            }
            else if (count0 % 2 != 0 && count1 % 2 != 0)
            {
                return "Great";
            }
            else if (count0 % 2 == 0 && count1 % 2 != 0)
            {
                throw new ExceptionOne("One comes odd times");
            }
            else if (count0 % 2 != 0 && count1 % 2 == 0)
            {
                throw new ExceptionZero("Zero comes odd times");

            }
            else
            {
                return "Error";
            }
        }
    }
}
