namespace LeetCodeSolutionsProject.Problems.Medium.Single_Number_III;

public class Solution
{
    public int[] SingleNumber(int[] nums)
    {
        Dictionary<int, bool> map = [];
        List<int> rs = [];

        foreach (int num in nums)
        {
            if (!map.TryAdd(num, false))
            {
                map[num] = true;
            }
        }

        foreach (var item in map)
        {
            if (!item.Value)
            {
                rs.Add(item.Key);
            }
        }

        return [.. rs];
    }
}