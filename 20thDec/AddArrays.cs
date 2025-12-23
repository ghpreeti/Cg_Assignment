using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20thDec
{
    internal class AddArrays
    {
        public static void Run()
        {
            Console.WriteLine("Enter Array1 Size:");
            int n = Int32.Parse(Console.ReadLine());

            double[] arr1 = new double[n];
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Int32.Parse(Console.ReadLine()); // one num in one line
            }


            Console.WriteLine("Enter Array2 Size:");
            int m = Int32.Parse(Console.ReadLine());

            double[] arr2 = new double[m];
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < m; i++)
            {
                arr2[i] = Int32.Parse(Console.ReadLine()); // one num in one line
            }


            //BL
            int max = arr1.Length > arr2.Length ? arr1.Length : arr2.Length;
            int[] ans = new int[max];

            for (int i = 0; i < max; i++)
            {
                double num1 = i < arr1.Length ? arr1[i] : 0;//check for null at index
                double num2 = i < arr2.Length ? arr2[i] : 0;

                ans[i] = (int)(num1 + num2);
            }


            foreach(int val in ans)
            {
                Console.Write(val+" ");
            }

        }


    }
}
