namespace LeetCodeSolutionsProject.Problems.Easy._1662._Check_If_Two_String_Arrays_are_Equivalent;

public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var w1 = string.Join("", word1);
        var w2 = string.Join("", word2);

        return w1.Equals(w2);
    }
}
