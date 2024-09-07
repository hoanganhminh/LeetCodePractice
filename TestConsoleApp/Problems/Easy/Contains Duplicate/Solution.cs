namespace TestConsoleApp.Problems.Easy.Contains_Duplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        bool rs = nums.Length != nums.Distinct().Count();
        return rs;
    }
}