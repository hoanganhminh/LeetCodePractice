namespace LeetCodeSolutionsProject.Problems.Easy.Sum_of_Digits_of_String_After_Convert;

public class Solution
{
    public int GetLucky(string s, int k)
    {
        s = s.ToLower();
        char[] chars = s.ToCharArray();
        s = "";
        int sum = 0;

        foreach (char c in chars)
        {
            s += ((int)c - 96);
        }

        for (int i = 0; i < k; i++)
        {
            sum = 0;

            foreach (var item in s.ToCharArray())
            {
                sum += int.Parse(item.ToString());
            };

            s = sum.ToString();
        }

        return sum;
    }
}