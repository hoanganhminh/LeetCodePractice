namespace TestConsoleApp.Problems.Medium.Reverse_Words_in_a_String;

public class Solution
{
    public string ReverseWords(string s)
    {
        var sArr = s.Split(" ").Where(x => x != "").Reverse();

        return string.Join(" ", sArr);
    }
}