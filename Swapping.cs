using System;
class Swapping
{
    public static SwapRef(ref int a, ref int b)
    {
        a = a+b;
        b = a-b;
        a = a-b;
    }

    public static void SwapOut(int a,int b, out int newA,out int newB)
    {
        newA = a + b;
        newB = newA - b;
        newA = newA - newB;
    }
}