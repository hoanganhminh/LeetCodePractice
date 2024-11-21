namespace TestConsoleApp.Problems.Easy.Rotate_String;

public class Solution
{
    public bool RotateString(string s, string goal)
    {
        foreach (var c in s)
        {
            s = s.Substring(1, s.Length - 1);
            s += c;

            if (s == goal)
            {
                return true;
            }
        }

        return false;
    }
}