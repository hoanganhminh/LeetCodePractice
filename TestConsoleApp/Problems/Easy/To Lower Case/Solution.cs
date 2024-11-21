namespace TestConsoleApp.Problems.Easy.To_Lower_Case;

public class Solution
{
    public string ToLowerCase(string s)
    {
        var result = string.Empty;

        foreach (char c in s)
        {
            if (c >= 'A' && c <= 'Z')
            {
                result += (char)(c + 32);
            }
            else
            {
                result += c;
            }
        }

        return result;
    }
}