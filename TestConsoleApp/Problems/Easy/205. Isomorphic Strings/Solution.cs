namespace LeetCodeSolutionsProject.Problems.Easy._205._Isomorphic_Strings;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var dic = new Dictionary<char, char>();
        var usedValue = new Dictionary<char, bool>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dic.ContainsKey(s[i]))
            {
                if (!usedValue.TryAdd(t[i], true))
                {
                    return false;
                }
                else
                {
                    dic.Add(s[i], t[i]);
                }
            }
            else
            {
                if (dic[s[i]] != t[i]) { return false; }
            }
        }

        return true;
    }
}
