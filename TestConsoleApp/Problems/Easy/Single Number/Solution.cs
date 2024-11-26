namespace LeetCodeSolutionsProject.Problems.Easy.Single_Number;

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        bool flag = true;

        for (int i = 0; i < nums.Length; i++)
        {
            flag = true;

            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (nums[j] == nums[i])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                return nums[i];
            }
        }

        return 0;
    }

    //public int SingleNumber(int[] nums)
    //{
    //    if (nums.Length == 1)
    //        return nums[0];

    //    foreach (int num in nums)
    //    {
    //        if (nums.Where(x => x == num).Count() == 1)
    //        {
    //            return num;
    //        }
    //    }

    //    return 0;
    //}
}