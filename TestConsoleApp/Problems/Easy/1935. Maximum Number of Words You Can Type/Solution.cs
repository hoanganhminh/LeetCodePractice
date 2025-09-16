namespace LeetCodeSolutionsProject.Problems.Easy._1935._Maximum_Number_of_Words_You_Can_Type;

public class Solution
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        var sArr = text.Split(' ');

        return sArr.Where(x => !CheckMacth(x, brokenLetters.ToCharArray())).Count();
    }

    private bool CheckMacth(string text, char[] chars)
    {
        foreach (var c in chars)
        {
            if (text.Contains(c))
            {
                return true;
            }
        }

        return false;
    }
}