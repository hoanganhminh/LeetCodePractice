namespace TestConsoleApp.Problems.Easy.Max_Consecutive_Ones;

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var max = 0;
        var currentMax = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            currentMax = nums[i] == 1 ? currentMax + 1 : 0;

            if (currentMax > max)
            {
                max = currentMax;
            }
        }

        return max;
    }
}
