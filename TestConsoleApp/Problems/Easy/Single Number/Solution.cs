﻿namespace LeetCodeSolutionsProject.Problems.Easy.Single_Number;

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Dictionary<int, bool> map = [];

        foreach (int num in nums)
        {
            if (!map.TryAdd(num, false))
            {
                map[num] = true;
            }
        }

        foreach (var item in map)
        {
            if (!item.Value)
            {
                return item.Key;
            }
        }

        return 0;
    }
}