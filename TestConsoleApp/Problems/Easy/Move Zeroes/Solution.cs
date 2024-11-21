namespace TestConsoleApp.Problems.Easy.Move_Zeroes;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var copyNums = nums.Where(x => x != 0).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i >= copyNums.Length ? 0 : copyNums[i];
        }
    }
}
