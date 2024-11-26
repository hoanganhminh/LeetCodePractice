namespace LeetCodeSolutionsProject.Problems.Easy.Word_Pattern;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var stringArr = s.Split(' ');

        if (stringArr.Length != pattern.Length)
        {
            return false;
        }

        Dictionary<char, string> dic = [];

        for (int i = 0; i < pattern.Length; i++)
        {
            if (dic.ContainsKey(pattern[i])
                && dic.GetValueOrDefault(pattern[i]) != stringArr[i])
            {
                return false;
            }

            if (!dic.ContainsKey(pattern[i]))
            {
                if (dic.FirstOrDefault(x => x.Value == stringArr[i]).Value != null)
                {
                    return false;
                }

                dic.Add(pattern[i], stringArr[i]);
            }
        }

        return true;
    }
}