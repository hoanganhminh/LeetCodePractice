namespace LeetCodeSolutionsProject.Problems.Easy.Number_of_Good_Pairs;

public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        var count = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }
        }

        return count;
    }
}