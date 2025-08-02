namespace LeetCodeSolutionsProject.Problems.Easy._414._Third_Maximum_Number;

public class Solution
{
    public int ThirdMax(int[] nums)
    {
        var dic = new Dictionary<int, bool>();
        var min = int.MinValue;
        var max = min;
        var max2nd = min;
        var max3th = min;

        foreach (var item in nums)
        {
            dic.TryAdd(item, false);
        }

        foreach (var item in dic.Keys)
        {
            if (item > max) { max3th = max2nd; max2nd = max; max = item; }
            else if (item > max2nd) { max3th = max2nd; max2nd = item; }
            else if (item > max3th) { max3th = item; }
        }

        if (dic.Keys.Count >= 3) { return max3th; }

        return max;
    }
}