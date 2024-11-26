namespace LeetCodeSolutionsProject.Problems.Easy.Remove_Duplicates_from_Sorted_Array;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var arr = nums.Distinct().ToArray();

        for (int i = 0; i < arr.Length; i++)
        {
            nums[i] = arr[i];
        }

        return arr.Length;
    }
}