namespace LeetCodeSolutionsProject.Problems.Easy._345._Reverse_Vowels_of_a_String;

public class Solution
{
    public string ReverseVowels(string s)
    {
        List<int> visited = [];
        Dictionary<char, bool> vowels = new()
        {
            {'a', true},
            {'e', true},
            {'i', true},
            {'o', true},
            {'u', true},
            {'A', true},
            {'E', true},
            {'I', true},
            {'O', true},
            {'U', true}
        };

        var index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.ContainsKey(s[i]))
            {
                visited.Add(i);
                index++;
            }
        }

        var sArr = s.ToCharArray();
        for (int i = 0; i < visited.Count / 2; i++)
        {
            (sArr[visited[visited.Count - 1 - i]], sArr[visited[i]]) = (sArr[visited[i]], sArr[visited[visited.Count - 1 - i]]);
        }

        return new string(sArr);
    }
}
