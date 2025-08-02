namespace LeetCodeSolutionsProject.Problems.Easy._500._Keyboard_Row;

public class Solution
{
    public string[] FindWords(string[] words)
    {
        var r1 = new HashSet<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
        var r2 = new HashSet<char>() { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
        var r3 = new HashSet<char>() { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

        var rs = new List<string>();

        foreach (var word in words)
        {
            var wordLowerCase = word.ToLower();

            if (r1.Contains(wordLowerCase[0]))
            {
                if (correctWord(wordLowerCase, r1)) { rs.Add(word); }
            }
            else if (r2.Contains(wordLowerCase[0]))
            {
                if (correctWord(wordLowerCase, r2)) { rs.Add(word); }
            }
            else
            {
                if (correctWord(wordLowerCase, r3)) { rs.Add(word); }
            }
        }

        return [.. rs];
    }

    private bool correctWord(string word, HashSet<char> chars)
    {
        foreach (var c in word)
        {
            if (!chars.Contains(c))
            {
                return false;
            }
        }

        return true;
    }
}