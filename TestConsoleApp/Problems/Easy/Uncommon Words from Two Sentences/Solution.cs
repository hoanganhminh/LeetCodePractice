namespace LeetCodeSolutionsProject.Problems.Easy.Uncommon_Words_from_Two_Sentences;

public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var arr = s2.Split(' ').ToList();
        arr.AddRange(s1.Split(' '));

        var rs = new List<string>();

        arr.Distinct().ToList().ForEach(x =>
        {
            if (arr.FindAll(y => y.Equals(x)).Count == 1)
            {
                rs.Add(x);
            }
        });

        return rs.ToArray();
    }
}