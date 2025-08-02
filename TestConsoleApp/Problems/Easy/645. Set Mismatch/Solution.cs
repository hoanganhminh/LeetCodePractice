namespace LeetCodeSolutionsProject.Problems.Easy._645._Set_Mismatch;

public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        var d = new Dictionary<int, bool>();
        var rs = 0;

        foreach (var i in nums)
        {
            if (!d.TryAdd(i, true))
            {
                rs = i;
            }
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!d.ContainsKey(i))
            {
                return [rs, i];
            }
        }

        return [];
    }
}