namespace LeetCodeSolutionsProject.Problems.Easy._171._Excel_Sheet_Column_Number;

public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        var rs = 0.0;

        for (int i = 0; i < columnTitle.Length; i++)
        {
            rs += Math.Pow(26, columnTitle.Length - i - 1) * (columnTitle[i] - 64);
        }

        return (int)rs;
    }
}