namespace TestConsoleApp.Problems.Easy.Valid_Palindrome;

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


        if (lettersOnly.Count == 1)
            return true;

        int position = lettersOnly.Count % 2 == 0 ? 0 : 1;
        var f = lettersOnly.Skip(0).Take((lettersOnly.Count) / 2).ToList();
        var l = lettersOnly.Skip((lettersOnly.Count) / 2 + position).Reverse().ToList();

        return Enumerable.SequenceEqual(f, l);
    }
}
