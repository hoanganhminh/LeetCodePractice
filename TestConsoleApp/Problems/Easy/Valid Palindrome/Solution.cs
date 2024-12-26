namespace LeetCodeSolutionsProject.Problems.Easy.Valid_Palindrome;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        s = s.Trim();

        if (s == "")
        {
            return true;
        }

        var lettersOnly = s.ToLower().Where(x => char.IsLetterOrDigit(x)).ToList();
        var left = 0;
        var right = lettersOnly.Count - 1;

        while (left <= right)
        {
            if (lettersOnly[left] != lettersOnly[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
