namespace LeetCodeSolutionsProject.Problems.Easy.Contains_Duplicate_II;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> dic = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.TryGetValue(nums[i], out int index))
            {
                if (nums[i] == nums[index] && Math.Abs(i - index) <= k)
                {
                    return true;
                }
                else
                {
                    dic[nums[i]] = i;
                }
            }
            else
            {
                dic.Add(nums[i], i);
            }
        }

        return false;
    }
}