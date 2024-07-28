namespace TestConsoleApp.Problems.Easy.Two_Sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int currentTarget;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                currentTarget = nums[i] + nums[j];

                if (currentTarget == target)
                {
                    int[] result = { i, j };

                    return result;
                }
            }
        }

        return [];
    }
}
