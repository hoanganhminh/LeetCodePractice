namespace LeetCodeSolutionsProject.Problems.Easy.Two_Sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.TryGetValue(nums[i], out int val))
            {
                return [i, val];
            }

            dic.TryAdd(target - nums[i], i);
        }

        return [];
    }
}