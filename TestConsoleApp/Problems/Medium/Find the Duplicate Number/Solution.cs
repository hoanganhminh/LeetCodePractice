namespace LeetCodeSolutionsProject.Problems.Medium.Find_the_Duplicate_Number;

public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        Dictionary<int, bool> dic = [];

        foreach (var i in nums)
        {
            if (!dic.TryAdd(i, true))
            {
                return i;
            }
        }

        return 0;
    }
}
