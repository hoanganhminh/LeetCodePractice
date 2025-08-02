namespace LeetCodeSolutionsProject.Problems.Easy._168._Excel_Sheet_Column_Title;

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        var result = "";

        while (columnNumber > 0)
        {
            var second = (columnNumber - 1) % 26;
            result = (char)(second + 65) + result;
            columnNumber = (columnNumber - 1) / 26;
        }

        return result;
    }
}