namespace LeetCodeSolutionsProject.Problems.Hard.First_Missing_Positive;

public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        Dictionary<int, int> dic = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                dic.TryAdd(nums[i], i);
            }
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!dic.ContainsKey(i))
            {
                return i;
            }
        }

        return nums.Length + 1;
    }
}