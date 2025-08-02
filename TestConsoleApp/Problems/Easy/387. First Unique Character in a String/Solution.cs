namespace LeetCodeSolutionsProject.Problems.Easy._387._First_Unique_Character_in_a_String;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var d = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!d.TryAdd(s[i], i))
            {
                d[s[i]] = -1;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (d.TryGetValue(s[i], out var c))
            {
                if (c >= 0)
                {
                    return c;
                }
            }
        }

        return -1;
    }
}
