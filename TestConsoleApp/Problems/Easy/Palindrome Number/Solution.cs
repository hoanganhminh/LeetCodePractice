namespace TestConsoleApp.Problems.Easy.Palindrome_Number;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        char[] list = x.ToString().ToCharArray();

        if (String.Join("", list.Reverse().ToArray()) != String.Join("", list))
        {
            return false;
        }

        return true;
    }
}
