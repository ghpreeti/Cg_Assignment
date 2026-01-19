using System.ComponentModel.DataAnnotations.Schema;

class MultiplicationTable
{
    public static int[] GenerateTable(int n, int upto)
    {
        int[] table = new int[upto];
        for(int i = 0; i < upto; i++)
        {
            table[i] = n*(i+1);
        }
        return table;
    }
}