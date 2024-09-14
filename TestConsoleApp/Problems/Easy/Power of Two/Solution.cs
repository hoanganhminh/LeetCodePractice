namespace TestConsoleApp.Problems.Easy.Power_of_Two;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n < 1) return false;

        var nBinary = Convert.ToString(n, 2);

        return (nBinary[0] == '1' && nBinary.Split('1').Length == 2);
    }
}