namespace TestConsoleApp.Problems.Easy.Contains_Duplicate_II;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums.Length == nums.Distinct().Count())
            return false;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && Math.Abs(i - j) <= k)
                {
                    return true;
                }
            }
        }

        return false;
    }
}