﻿namespace LeetCodeSolutionsProject.Problems.Easy.Missing_Number;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        return nums.Length * (nums.Length + 1) / 2 - nums.Sum();
    }
}