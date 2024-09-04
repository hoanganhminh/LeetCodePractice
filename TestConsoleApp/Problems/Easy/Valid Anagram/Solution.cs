namespace TestConsoleApp.Problems.Easy.Valid_Anagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var c1 = s.ToCharArray().Order().ToArray();
        var c2 = t.ToCharArray().Order().ToArray();

        for (int i = 0; i < c1.Length; i++)
        {
            if (c1[i] != c2[i])
                return false;
        }

        return true;
    }
}