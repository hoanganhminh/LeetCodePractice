namespace LeetCodeSolutionsProject.Problems.Medium.Find_All_Duplicates_in_an_Array;

public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        HashSet<int> hsNums = [];
        List<int> list = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!hsNums.Add(nums[i]))
            {
                list.Add(nums[i]);
            }
        }

        return list;
    }
}