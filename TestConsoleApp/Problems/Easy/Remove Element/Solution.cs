namespace LeetCodeSolutionsProject.Problems.Easy.Remove_Element;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var arr = nums.Where(x => x != val).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i < arr.Length)
            {
                nums[i] = arr[i];
            }
        }

        return arr.Length;
    }
}
