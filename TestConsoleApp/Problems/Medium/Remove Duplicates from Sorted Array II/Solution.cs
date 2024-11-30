namespace LeetCodeSolutionsProject.Problems.Medium.Remove_Duplicates_from_Sorted_Array_II;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var lsNums = nums.ToList();
        Dictionary<int, int> dic = [];

        foreach (var item in nums)
        {
            if (dic.TryGetValue(item, out int value))
            {
                dic[item] = ++value;

                if (value > 2)
                {
                    lsNums.Remove(item);
                }
            }
            else
            {
                dic.Add(item, 1);
            }
        }

        for (int i = 0; i < lsNums.Count; i++)
        {
            nums[i] = lsNums[i];
        }

        return lsNums.Count;
    }
}
