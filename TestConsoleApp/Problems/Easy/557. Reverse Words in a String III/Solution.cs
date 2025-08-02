namespace LeetCodeSolutionsProject.Problems.Easy._557._Reverse_Words_in_a_String_III;

public class Solution
{
    public string ReverseWords(string s)
    {
        var rs = new List<string>();
        var listS = s.Split(' ');

        foreach (var w in listS)
        {
            var wordLenght = w.Length;

            if (wordLenght > 1)
            {
                var listChar = w.ToCharArray();

                for (int i = 0; i < wordLenght / 2; i++)
                {
                    (listChar[wordLenght - 1 - i], listChar[i]) = (listChar[i], listChar[wordLenght - 1 - i]);
                }

                rs.Add(new String(listChar));
            }
            else
            {
                rs.Add(w);
            }
        }

        return String.Join(" ", rs);
    }
}
