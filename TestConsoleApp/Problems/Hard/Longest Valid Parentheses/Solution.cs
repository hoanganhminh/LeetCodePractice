namespace LeetCodeSolutionsProject.Problems.Hard.Longest_Valid_Parentheses;

public class Solution
{
    public int LongestValidParentheses(string s)
    {
        if (s.Length < 2) return 0;

        s = ')' + s + '(';

        var listChar = s.ToList();
        List<string> listStr = new List<string>();

        listChar.ForEach(x =>
        {
            listStr.Add(x + "");
        });

        bool continueLoop = true;

        while (continueLoop)
        {
            continueLoop = false;

            for (int i = 0; i < listStr.Count - 1; i++)
            {
                if (listStr[i] == ")") continue;

                if (NotValidChar(listStr[i]) && NotValidChar(listStr[i + 1]))
                {
                    listStr[i] = int.Parse(listStr[i].ToString()) + int.Parse(listStr[i + 1].ToString()) + "";
                    listStr.RemoveAt(i + 1);
                    continueLoop = true;
                    continue;
                }

                if (listStr[i] == "(" && NotValidChar(listStr[i + 1]) && listStr[i + 2] == ")")
                {
                    listStr.RemoveAt(i);
                    listStr[i] = int.Parse(listStr[i].ToString()) + 1 + "";
                    listStr.RemoveAt(i + 1);
                    continueLoop = true;
                    continue;
                }

                if (listStr[i] == "(" && listStr[i + 1] == ")")
                {
                    listStr[i] = "1";
                    listStr.RemoveAt(i + 1);
                    continueLoop = true;
                    continue;
                }
            }
        }

        listStr = listStr.Distinct().ToList();

        listStr.Remove("(");
        listStr.Remove(")");

        if (listStr.Count == 0) return 0;

        List<int> listInt = new List<int>();
        listStr.ForEach(s =>
        {
            listInt.Add(int.Parse(s));
        });

        return listInt.Max() * 2;
    }

    private bool NotValidChar(string s)
    {
        return s != "(" && s != ")";
    }
}