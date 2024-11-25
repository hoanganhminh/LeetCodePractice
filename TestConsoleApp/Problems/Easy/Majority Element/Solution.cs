namespace TestConsoleApp.Problems.Easy.Majority_Element;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        foreach (var item in nums.ToHashSet())
        {
            if (nums.Where(x => x == item).Count() > nums.Length / 2)
            {
                return item;
            }
        }

        return 0;
    }
}