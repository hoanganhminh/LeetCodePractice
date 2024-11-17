namespace TestConsoleApp.Problems.Easy.Find_the_Difference;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        if (s == "")
        {
            return t[0];
        }

        var tList = t.ToCharArray().ToList();

        foreach (char x in s)
        {
            tList.Remove(x);
        }

        return tList[0];
    }
}
