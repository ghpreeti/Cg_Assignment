class SortedArrays
{
    public static T[] mergedArray<T>(T[] a,T[] b) where T : IComparable<T>
    {
        int n = a.Length;
        int m = b.Length;
        T[] merged = new T[n+m];

        int i;
        int j;
        int k;

        while(i<n && j < m)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                merged[k++] = a[i++];
            }
            else
            {
                merged[k++] = b[j++];
            }
        }

        while (i < n)
        {
            merged[k++] = a[i++];
        }
        while (j < m)
        {
            merged[k++] = b[j++];
        }
     
        return merged;
    }
}