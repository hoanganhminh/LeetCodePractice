namespace LeetCodeSolutionsProject.Problems.Easy._448._Find_All_Numbers_Disappeared_in_an_Array;

public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var d = new Dictionary<int, bool>();
        var rs = new List<int>();

        foreach (var x in nums)
        {
            d.TryAdd(x, true);
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!d.ContainsKey(i))
            {
                rs.Add(i);
            }
        }

        return rs;
    }
}
