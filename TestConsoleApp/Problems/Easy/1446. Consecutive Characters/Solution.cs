namespace LeetCodeSolutionsProject.Problems.Easy._1446._Consecutive_Characters;

public class Solution
{
    public int MaxPower(string s)
    {
        var streak = 1;
        var currentStreak = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                currentStreak++;
                streak = currentStreak > streak ? currentStreak : streak;
            }
            else
            {
                currentStreak = 1;
            }
        }

        return streak;
    }
}