namespace TestConsoleApp.Problems.Easy.Number_Complement;

public class Solution
{
    public int FindComplement(int num)
    {
        var binary = Convert.ToString(num, 2);
        var complement = "";
        foreach (char c in binary)
        {
            complement += c == '1' ? 0 : 1;
        }
        return Convert.ToInt32(complement, 2);
    }
}