namespace LeetCodeSolutionsProject.Problems.Easy.Shuffle_String;

public class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        char[] rs = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            rs[indices[i]] = s[i];
        }

        return new string(rs);
    }
}
