namespace LeetCodeSolutionsProject.Problems.Easy.Count_the_Number_of_Consistent_Strings;

public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        int invalid = 0;

        foreach (var item in words)
        {
            foreach (char c in item)
            {
                if (!allowed.Contains(c))
                {
                    invalid++;
                    break;
                }
            }
        }

        return words.Length - invalid;
    }
}