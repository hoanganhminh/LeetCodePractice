namespace LeetCodeSolutionsProject.Problems.Easy._1160._Find_Words_That_Can_Be_Formed_by_Characters;

public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        var dic = new Dictionary<char, int>();
        var rs = 0;

        foreach (var c in chars)
        {
            if (!dic.TryAdd(c, 1))
            {
                dic[c] += 1;
            }
        }

        foreach (var word in words)
        {
            var dicTemp = new Dictionary<char, int>(dic);
            var flag = true;
            foreach (var c in word)
            {
                if (!dicTemp.ContainsKey(c))
                {
                    flag = false;
                    break;
                }
                else
                {
                    if (dicTemp[c] == 1)
                    {
                        dicTemp.Remove(c);
                    }
                    else
                    {
                        dicTemp[c] -= 1;
                    }
                }
            }
            if (flag)
            {
                rs += word.Length;
            }
        }

        return rs;
    }
}
