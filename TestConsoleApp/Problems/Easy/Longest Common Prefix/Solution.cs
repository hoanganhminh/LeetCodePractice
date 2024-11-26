namespace LeetCodeSolutionsProject.Problems.Easy.Longest_Common_Prefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        strs = strs.OrderBy(strs => strs.Length).ToArray();

        var commonPrefix = "";
        var firstStringCharList = strs[0].ToCharArray();
        var checkDifferent = false;

        for (int i = 0; i < firstStringCharList.Length; i++)
        {
            for (int j = 0; j < strs.Length; j++)
            {
                if (j + 1 >= strs.Length)
                    break;

                if (firstStringCharList[i] != strs[j + 1][i])
                {
                    checkDifferent = true;
                    break;
                }
            }

            if (checkDifferent)
                break;

            commonPrefix += firstStringCharList[i];
        }

        return commonPrefix;
    }
}
