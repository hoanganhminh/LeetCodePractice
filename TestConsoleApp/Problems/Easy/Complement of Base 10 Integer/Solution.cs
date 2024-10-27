namespace TestConsoleApp.Problems.Easy.Complement_of_Base_10_Integer;

public class Solution
{
    public int BitwiseComplement(int n)
    {
        var binary = Convert.ToString(n, 2);
        var complement = "";
        foreach (char c in binary)
        {
            complement += c == '1' ? 0 : 1;
        }
        return Convert.ToInt32(complement, 2);
    }
}
