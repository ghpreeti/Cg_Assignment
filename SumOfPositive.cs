class SumOfPositive
{
    public static int Sum(int[] arr)
    {
        int ans = 0;
        foreach(int n in arr)
        {
            if(n==0){break;}
            else if(n<0){continue;}
            else{ans+=n;}

            return ans;
        }
    }
}