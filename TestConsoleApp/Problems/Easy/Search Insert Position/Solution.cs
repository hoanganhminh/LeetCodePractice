namespace LeetCodeSolutionsProject.Problems.Easy.Search_Insert_Position;
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (!nums.Contains(target))
        {
            nums = nums.Append(target).Order().ToArray();
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                return i;
        }

        return 0;
    }
}