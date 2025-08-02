namespace LeetCodeSolutionsProject.Problems.Easy._349._Intersection_of_Two_Arrays;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var dic = new Dictionary<int, bool>();
        var rs = new Dictionary<int, bool>();

        foreach (int i in nums1)
        {
            dic.TryAdd(i, true);
        }

        foreach (int i in nums2)
        {
            if (dic.ContainsKey(i))
            {
                rs.TryAdd(i, true);
            }
        }

        return [.. rs.Keys];
    }
}