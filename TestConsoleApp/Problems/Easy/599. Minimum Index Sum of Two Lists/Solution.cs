namespace LeetCodeSolutionsProject.Problems.Easy._599._Minimum_Index_Sum_of_Two_Lists;

public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var dic = new Dictionary<string, int>();
        var fillterDic = new Dictionary<string, int>();
        List<string> rs = [];
        var min = int.MaxValue;

        for (int i = 0; i < list1.Length; i++)
        {
            dic.Add((string)list1[i], i);
        }

        for (int i = 0; i < list2.Length; i++)
        {
            if (!dic.TryAdd(list2[i], i))
            {
                var sum = dic[list2[i]] + i;
                if (sum <= min)
                {
                    min = sum;
                    fillterDic.Add(list2[i], sum);
                }
            }
        }

        foreach (var i in fillterDic)
        {
            if (i.Value == min)
            {
                rs.Add(i.Key);
            }
        }

        return [.. rs];
    }
}