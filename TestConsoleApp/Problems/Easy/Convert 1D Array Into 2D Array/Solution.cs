namespace TestConsoleApp.Problems.Easy.Convert_1D_Array_Into_2D_Array;

public class Solution
{
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        bool validate = (m < 1) || (original.Length / n < 1) || (m != (original.Length / n) + (original.Length % n));

        if (validate)
        {
            return [];
        }

        int[][] a = new int[m][];

        for (int i = 0; i < m; i++)
        {
            a[i] = original.Skip(i * n).Take(n).ToArray();
        }

        return a;
    }
}