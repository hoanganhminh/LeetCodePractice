namespace LeetCodeSolutionsProject.Problems.Easy._350._Intersection_of_Two_Arrays_II;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var dic = new Dictionary<int, int>();

        foreach (int i in nums1)
        {
            if (!dic.TryAdd(i, 0))
            {
                dic[i] = dic[i] + 1;
            }
        }

        var rs = new List<int>();

        foreach (int i in nums2)
        {
            if (dic.ContainsKey(i))
            {
                rs.Add(i);
                if (dic[i] > 0)
                {
                    dic[i] = dic[i] - 1;
                }
                else
                {
                    dic.Remove(i);
                }
            }
        }

        return [.. rs];
    }
}