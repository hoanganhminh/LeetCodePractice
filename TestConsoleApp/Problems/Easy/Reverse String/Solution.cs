namespace TestConsoleApp.Problems.Easy.Reverse_String;

public class Solution
{
    public void ReverseString(char[] s)
    {
        var rv = s.Reverse().ToArray();
        for (int i = 0; i < s.Length; i++)
        {
            s[i] = rv[i];
        }
    }
}