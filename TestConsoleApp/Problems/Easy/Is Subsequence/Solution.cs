namespace LeetCodeSolutionsProject.Problems.Easy.Is_Subsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (t.Length < s.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            while (s[i] != t[i])
            {
                t = t.Remove(i, 1);

                if (t.Length < s.Length)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
