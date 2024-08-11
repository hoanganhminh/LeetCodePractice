namespace TestConsoleApp.Problems.Easy.Length_of_Last_Word;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        if(s.Trim().Length == 0) return 0;

        return s.Trim().Split(' ').Last().Length;
    }
}