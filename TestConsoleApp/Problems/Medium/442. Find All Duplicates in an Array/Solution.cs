namespace LeetCodeSolutionsProject.Problems.Medium._442._Find_All_Duplicates_in_an_Array;

public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var d = new Dictionary<int, bool>();
        List<int> list = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!d.TryAdd(nums[i], false))
            {
                list.Add(nums[i]);
            }
        }

        return list;
    }
}
