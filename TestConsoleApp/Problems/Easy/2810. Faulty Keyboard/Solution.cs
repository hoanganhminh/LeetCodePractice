namespace LeetCodeSolutionsProject.Problems.Easy._2810._Faulty_Keyboard;

public class Solution
{
    public string FinalString(string s)
    {
        var rs = new List<char>();

        foreach (var c in s)
        {
            if (c == 'i')
            {
                rs.Reverse();
            }
            else
            {
                rs.Add(c);
            }
        }

        return new string([.. rs]);
    }
}