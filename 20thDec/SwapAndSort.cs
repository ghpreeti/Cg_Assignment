using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20thDec
{
    internal class SwapAndSort
    {
        public static void Run()
        { 

            Console.WriteLine("Enter number of elements:");
            int n = Int32.Parse(Console.ReadLine());


            int[] arr = new int[n];
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++){
                arr[i] = Int32.Parse(Console.ReadLine()); // one num in one line
            }

            //BL
            for (int i = 0; i < n-1; i++){
                for (int j = 0; j < n-i-1; j++){
                    if (arr[j] > arr[j+1])
                    {
                        Swap(ref arr[j], ref arr[j+1]);
                    }
                }
            }

            foreach(int val in arr)
            {
                Console.Write(val + " ");
            }
            
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
