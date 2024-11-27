namespace LeetCodeSolutionsProject.Problems.Easy.Missing_Number;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var currentSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
        }

        return nums.Length * (nums.Length + 1) / 2 - currentSum;
    }
}