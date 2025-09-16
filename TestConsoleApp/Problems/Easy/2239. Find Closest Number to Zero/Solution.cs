namespace LeetCodeSolutionsProject.Problems.Easy._2239._Find_Closest_Number_to_Zero;

public class Solution
{
    public int FindClosestNumber(int[] nums)
    {
        int closest = int.MaxValue;
        int maxClosest = 0;

        foreach (int x in nums)
        {
            if (Math.Abs(x) < closest)
            {
                closest = Math.Abs(x);
                maxClosest = x;
            }
            else if (Math.Abs(x) == closest)
            {
                maxClosest = Math.Max(maxClosest, x);
            }
        }

        return maxClosest;
    }
}