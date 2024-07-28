namespace TestConsoleApp.Problems.Easy.Longest_Common_Prefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        strs = strs.OrderByDescending(strs => strs.Length).Reverse().ToArray();

        var commonPrefix = "";
        var firstStringCharList = strs[0].ToCharArray();
        var checkDifferent = false;


        for (int i = 0; i < firstStringCharList.Length; i++)
        {
            for (int j = 0; j < strs.Length; j++)
            {
                if (firstStringCharList[i] != strs[j + 1].ToCharArray()[i])
                {
                    checkDifferent = true;
                    break;
                }
            }

            if (checkDifferent)
                break;

            commonPrefix += firstStringCharList[i].ToString();
        }

        return commonPrefix;
    }
}
