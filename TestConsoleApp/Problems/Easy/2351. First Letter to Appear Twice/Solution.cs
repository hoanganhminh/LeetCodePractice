namespace LeetCodeSolutionsProject.Problems.Easy._2351._First_Letter_to_Appear_Twice;

public class Solution
{
    public char RepeatedCharacter(string s)
    {
        var d = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!d.TryAdd(s[i], 1))
            {
                return s[i];
            }
        }

        return 'a';
    }
}
