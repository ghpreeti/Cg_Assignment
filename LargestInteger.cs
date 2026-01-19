class LargestInteger
{
    public static int Largest(int a,int b,int c)
    {
        int ans = 0;
        if(a>b && a > c)
        {
            ans = a;
        }else if(b>a && b > c)
        {
            ans = b;
        }
        else
        {
            ans =c;
        }
        return ans;
    }
}