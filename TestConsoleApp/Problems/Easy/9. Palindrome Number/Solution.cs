namespace LeetCodeSolutionsProject.Problems.Easy._9._Palindrome_Number;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        char[] list = x.ToString().ToCharArray();

        if (String.Join("", list.Reverse().ToArray()) != String.Join("", list))
        {
            return false;
        }

        return true;
    }
}